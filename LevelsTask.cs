using System;
using System.Collections.Generic;

namespace func_rocket;

public class LevelsTask
{
	static readonly Physics standardPhysics = new();

	public static IEnumerable<Level> CreateLevels()
	{
		yield return new Level("Zero", 
			new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
			new Vector(600, 200), 
			(size, v) => Vector.Zero, standardPhysics);
		yield return new Level("Heavy",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, e) => new Vector(0,0.9), standardPhysics);
        yield return new Level("Up",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(700, 500),
            (size, p) => new Vector(0, -300 / (size.Y-p.Y + 300.0)), standardPhysics);
        yield return new Level("WhiteHole",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, w) => new Vector(Math.Cos(Math.Atan2(w.Y-200,w.X-600))*140 * Math.Sqrt((w.Y - 200) * (w.Y - 200) + (w.X - 600) * (w.X - 600)) / ((w.Y - 200) * (w.Y - 200) + (w.X - 600) * (w.X - 600) + 1), Math.Sin(Math.Atan2(w.Y - 200, w.X - 600)) * 140 * Math.Sqrt((w.Y - 200) * (w.Y - 200) + (w.X - 600) * (w.X - 600)) / ((w.Y - 200) * (w.Y - 200) + (w.X - 600) * (w.X - 600) + 1)), standardPhysics);
        yield return new Level("BlackHole",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, r) => new Vector(Math.Cos(Math.Atan2(350-r.Y,400-r.X))*300*Math.Sqrt((400-r.X)*(400-r.X)+ (350 - r.Y) * (350 - r.Y)) /(((400 - r.X) * (400 - r.X) + (350 - r.Y) * (350 - r.Y))+1), Math.Sin(Math.Atan2(-r.Y + 350, -r.X +400)) * 300 * Math.Sqrt((400 - r.X) * (400 - r.X) + (350 - r.Y) * (350 - r.Y)) / (((400 - r.X) * (400 - r.X) + (350 - r.Y) * (350 - r.Y)) + 1)), standardPhysics);
        yield return new Level("BlackAndWhite",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, f) => new Vector(Math.Cos(Math.Atan2(f.Y - 200, f.X - 600)) * 140 * Math.Sqrt((f.Y - 200) * (f.Y - 200) + (f.X - 600) * (f.X - 600)) / ((f.Y - 200) * (f.Y - 200) + (f.X - 600) * (f.X - 600) + 1)/2+ Math.Cos(Math.Atan2(350 - f.Y, 400 - f.X)) * 300 * Math.Sqrt((400 - f.X) * (400 - f.X) + (350 - f.Y) * (350 - f.Y)) / (((400 - f.X) * (400 - f.X) + (350 - f.Y) * (350 - f.Y)) + 1)/2, Math.Sin(Math.Atan2(f.Y - 200, f.X - 600)) * 140 * Math.Sqrt((f.Y - 200) * (f.Y - 200) + (f.X - 600) * (f.X - 600)) / ((f.Y - 200) * (f.Y - 200) + (f.X - 600) * (f.X - 600) + 1) / 2 + Math.Sin(Math.Atan2(350 - f.Y, 400 - f.X)) * 300 * Math.Sqrt((400 - f.X) * (400 - f.X) + (350 - f.Y) * (350 - f.Y)) / (((400 - f.X) * (400 - f.X) + (350 - f.Y) * (350 - f.Y)) + 1) / 2), standardPhysics);

        //TODO: ...
    }
}