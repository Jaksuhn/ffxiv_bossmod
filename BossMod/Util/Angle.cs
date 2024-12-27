﻿namespace BossMod;

// wrapper around float, stores angle in radians, provides type-safety and convenience
// when describing rotation in world, common convention is 0 for 'south'/'down'/(0, -1) and increasing counterclockwise - so +90 is 'east'/'right'/(1, 0)
public record struct Angle(float Rad)
{
    public const float RadToDeg = 180 / MathF.PI;
    public const float DegToRad = MathF.PI / 180;

    public readonly float Deg => Rad * RadToDeg;

    public static Angle FromDirection(WDir dir) => new(MathF.Atan2(dir.X, dir.Z));
    public readonly WDir ToDirection() => new(Sin(), Cos());

    public static Angle operator +(Angle a, Angle b) => new(a.Rad + b.Rad);
    public static Angle operator -(Angle a, Angle b) => new(a.Rad - b.Rad);
    public static Angle operator -(Angle a) => new(-a.Rad);
    public static Angle operator *(Angle a, float b) => new(a.Rad * b);
    public static Angle operator *(float a, Angle b) => new(a * b.Rad);
    public static Angle operator /(Angle a, float b) => new(a.Rad / b);
    public readonly Angle Abs() => new(Math.Abs(Rad));
    public readonly float Sin() => MathF.Sin(Rad);
    public readonly float Cos() => MathF.Cos(Rad);
    public readonly float Tan() => MathF.Tan(Rad);
    public static Angle Asin(float x) => new(MathF.Asin(x));
    public static Angle Acos(float x) => new(MathF.Acos(x));

    public readonly Angle Normalized()
    {
        var r = Rad;
        while (r < -MathF.PI)
            r += 2 * MathF.PI;
        while (r > MathF.PI)
            r -= 2 * MathF.PI;
        return new(r);
    }

    public readonly bool AlmostEqual(Angle other, float epsRad) => Math.Abs((this - other).Normalized().Rad) <= epsRad;

    // closest distance to move from this angle to destination (== 0 if equal, >0 if moving in positive/CCW dir, <0 if moving in negative/CW dir)
    public readonly Angle DistanceToAngle(Angle other) => (other - this).Normalized();

    // returns 0 if angle is within range, positive value if min is closest, negative if max is closest
    public readonly Angle DistanceToRange(Angle min, Angle max)
    {
        var width = (max - min) * 0.5f;
        var midDist = DistanceToAngle((min + max) * 0.5f);
        return midDist.Rad > width.Rad ? midDist - width : midDist.Rad < -width.Rad ? midDist + width : default;
    }

    public override readonly string ToString() => Deg.ToString("f0");
}

public static class AngleExtensions
{
    public static Angle Radians(this float radians) => new(radians);
    public static Angle Degrees(this float degrees) => new(degrees * Angle.DegToRad);
    public static Angle Degrees(this int degrees) => new(degrees * Angle.DegToRad);
}
