﻿using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Laboratorium_3_i_4.Models
{
    static public class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                            .GetMember(enumValue.ToString())
                            .First()
                            .GetCustomAttribute<DisplayAttribute>()
                            .GetName();
        }
    }
}
