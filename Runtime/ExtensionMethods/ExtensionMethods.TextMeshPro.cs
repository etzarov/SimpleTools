﻿using UnityEngine;

namespace EthanZarov.SimpleTools
{
    public static partial class ExtensionMethods
    {
        /// <summary>
        /// Converts a Unity Color to a TMPro rich text string.
        /// </summary>
        /// <param name="Unity Color"></param>
        /// <returns>color=#YRCOLR, with caret brackets around it.</returns>
        public static string TMProRichText(this Color value)
        {
            return "<color=#" + ColorUtility.ToHtmlStringRGB(value) + ">";
        }

        public static string Bold(this string text)
        {
            return $"<b>{text}</b>";
        }

        public static string Italic(this string text)
        {
            return $"<i>{text}</i>";
        }

        public static string Underline(this string text)
        {
            return $"<u>{text}</u>";
        }

        public static string Resize(this string text, string sizeString)
        {
            return $"<size={sizeString}>{text}<size=100%>";
        }

        /// <summary>
        /// Colorizes a specific string.
        /// </summary>
        /// <param name="Hexadecimal Color">Color with a #?????? format.</param>
        public static string Colorize(this string text, string hexadecimalColor)
        {
            if (!hexadecimalColor[0].Equals('#')) hexadecimalColor = "#" + hexadecimalColor;
            return $"<color={hexadecimalColor}>{text}</color>";
        }

        //Overload
        /// <summary>
        /// Colorizes a specific string.
        /// </summary>
        /// <param name="Color">Color with Unity color format.</param>
        public static string Colorize(this string text, Color color)
        {
            return $"{color.TMProRichText()}{text}</color>";
        }

        public static string NegatizedWord(this string text, bool trueFalseValue)
        {
            if (!trueFalseValue) return text + "n't";
            else return text;
        }

    }

}