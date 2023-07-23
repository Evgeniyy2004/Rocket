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
            (size, v) => new Vector(0,-0.9), standardPhysics);
        yield return new Level("Up",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(700, 500),
            (size, v) => new Vector(0, 300 / (v.Y + 300.0)), standardPhysics);
        yield return new Level("WhiteHole",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, v) => new Vector(140 * (v.X-200) / ((v.X - 200) * (v.X - 200) + 1), 140 * (v.Y - 200) / ((v.Y - 200) * (v.Y - 200) + 1)), standardPhysics);
        yield return new Level("BlackHole",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, v) => new Vector(300 * (400 - v.X) / ((400-v.X) * (400-v.X) + 1), 300 * (350-v.Y) / ((350-v.Y) * (350-v.Y) + 1)), standardPhysics);
        yield return new Level("BlackAndWhite",
            new Rocket(new Vector(200, 500), Vector.Zero, -0.5 * Math.PI),
            new Vector(600, 200),
            (size, v) => new Vector(300 * (400 - v.X) / ((400 - v.X) * (400 - v.X) + 1)*0.5+ 140 * (v.X - 200) / ((v.X - 200) * (v.X - 200) + 1)*0.5, 140 * (v.Y - 200) / ((v.Y - 200) * (v.Y - 200) + 1)*0.5+ 300 * (350 - v.Y) / ((350 - v.Y) * (350 - v.Y) + 1)*0.5), standardPhysics);

        //TODO: ...
    }
}