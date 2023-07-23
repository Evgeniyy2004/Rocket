using System;
using System.Linq;
using System.Collections.Generic;
namespace func_rocket;

public class ForcesTask
{
    /// <summary>
    /// Создает делегат, возвращающий по ракете вектор силы тяги двигателей этой ракеты.
    /// Сила тяги направлена вдоль ракеты и равна по модулю forceValue.
    /// </summary>
    public static RocketForce GetThrustForce(double forceValue)
    {
        return x => new Vector(Math.Cos(x.Direction) * forceValue, Math.Sin(x.Direction) * forceValue);
    }

    /// <summary>
    /// Преобразует делегат силы гравитации, в делегат силы, действующей на ракету
    /// </summary>
    public static RocketForce ConvertGravityToForce(Gravity gravity, Vector spaceSize)
    {
        return x => gravity(spaceSize, x.Location);
    }

    /// <summary>
    /// Суммирует все переданные силы, действующие на ракету, и возвращает суммарную силу.
    /// </summary>
    public static RocketForce Sum(params RocketForce[] forces)
    {
        return x => new Vector(forces.ToList().Select(r => r(x))
                              .Select(p => p.X)
                              .Sum(), forces.ToList()
                                .Select(r => r(x)).Select(p => p.Y).Sum());
    }
}