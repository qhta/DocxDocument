﻿using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Text.Encodings.Web;
using DocumentFormat.OpenXml;

using NUnit.Framework;
using Qhta.Unicode;

namespace Qhta.OpenXmlTools;

public partial class TextProcessingTester
{
  /// <summary>
  /// Run a test Run elements encoding
  /// </summary>
  /// <param name="body"></param>
  public void TestCharEncoding(DX.OpenXmlCompositeElement body)
  {
    TestCharEncoding(body, TextOptions.RichText);
  }

  private void TestCharEncoding(DX.OpenXmlCompositeElement body, TextOptions options)
  {
    Console.OutputEncoding = Encoding.Unicode;
    int count = 0;
    int failed = 0;

    //var ucd = UnicodeData.Instance;
    //var points = ucd.SearchInCategories( "L | N").ToList();
    //foreach (var point in points)
    //{
    //  var charInfo = ucd[point];
    //  if (VerboseLevel > 0)
    //    Console.WriteLine($"{charInfo.CodePoint} {charInfo.Name} {charInfo.Category}");

    //}
    //Console.WriteLine($"Found {points.Count()} points");
    //return;
    if (VerboseLevel > 0)
      Console.WriteLine($"\nTest {options.Mode} characters encoding");

    //count += TestCharEncodingInCategory(body, UcdCategory.Cc, ref failed, options);
    //count += TestCharEncodingInCategories(body, "Z", ref failed, options);
    //count += TestCharEncodingInRange(body, '\x20', '\x7E', ref failed, options);
    //count += TestCharEncodingInRange(body, '\xA1','\xFF', ref failed, options);
    //count += TestCharEncodingInCategory(body, UcdCategory.Pd, ref failed, options);
    //count += TestCharEncodingInCategory(body, UcdCategory.Cf, ref failed, options);
    //count += TestCharEncodingInCategory(body, UcdCategory.Sk, ref failed, options);
    //count += TestCharEncodingInCategory(body, UcdCategory.Mn, ref failed, options);
    //count += TestCharEncodingInSet(body, CharUtils.SupChars, ref failed, options);
    //count += TestCharEncodingInSet(body, CharUtils.SubChars, ref failed, options);
    //count += TestCharEncodingInSet(body, CharUtils.RomanChars, ref failed, options);
    //count += TestCharEncodingInScript(body, "Latin", ref failed, options);

    if (VerboseLevel > 0)
    {
      int passed = count - failed;
      Console.WriteLine($" {passed} chars tests passed.");
      Console.WriteLine($" {failed} chars tests failed.");
    }
  }

  private int TestCharEncodingInCategory(DX.OpenXmlCompositeElement body, UcdCategory ctg, ref int errs, TextOptions options)
  {
    var sb = new StringBuilder();
    foreach (var codePoint in UnicodeData.Instance.SearchInCategories(ctg.ToString()))
    {
      if (codePoint<=0xFFFF)
      {
        var ch = (char)codePoint;
        sb.Append(ch);
      }
    }
    string text = sb.ToString();
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }

  private int TestCharEncodingInCategories(DX.OpenXmlCompositeElement body, string pattern, ref int errs, TextOptions options)
  {
    var sb = new StringBuilder();
    foreach (var codePoint in UnicodeData.Instance.SearchInCategories(pattern))
    {
      if (codePoint <= 0xFFFF)
      {
        var ch = (char)codePoint;
        sb.Append(ch);
      }
    }
    string text = sb.ToString();
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }

  private int TestCharEncodingInScript(DX.OpenXmlCompositeElement body, string script, ref int errs, TextOptions options)
  {
    if (UnicodeData.Instance.ScriptCodes.TryGetValue1(script, out var scriptCode))
      script = scriptCode;
    var sb = new StringBuilder();
    foreach (var codePoint in UnicodeData.Instance.SearchInScripts(script))
    {
      if (codePoint <= 0xFFFF)
      {
        var ch = (char)codePoint;
        sb.Append(ch);
      }
    }
    string text = sb.ToString();
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }
  private int TestCharEncodingInRange(DX.OpenXmlCompositeElement body, char from, char to, ref int errs, TextOptions options)
  {
    char[] chars = new char[to-from+1];
    for (int i = from; i <= to; i++)
    {
      chars[i-from] = (char)i;
    }
    string text = new string(chars);
    var count = TestCharEncoding(body, text, ref errs,options);
    return count;
  }

  private int TestCharEncodingInSet(DX.OpenXmlCompositeElement body, char[] values, ref int errs, TextOptions options)
  {
    char[] chars = new char[values.Length];
    for (int i = 0; i < values.Length; i++)
    {
      chars[i] = (char)values[i];
    }
    string text = new string(chars);
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }

  private int TestCharEncoding(DX.OpenXmlCompositeElement body, string str, ref int errs, TextOptions options)
  {
    int errs0 = errs;
    DXW.Text testText = new DXW.Text(str);
    options.GetTextWriter().Clear();
    var encodedText = testText.GetText(options);
    if (VerboseLevel > 1)
      Console.WriteLine($"  Encoded text:\n  {encodedText}");
    testText.SetText(encodedText, options);
    var str2 = testText.Text;
    List<string> errors = new List<string>();
    for (int i = 0; i < str.Length && i< str2.Length; i++)
    {
      if (str[i] != str2[i])
      {
        errs++;
        errors.Add($"[{i}] {HtmlEncoder.Default.Encode(new String(str[i],1))} <-> {HtmlEncoder.Default.Encode(new String(str2[i], 1))}");
      }
    }
    errs += Math.Abs(str.Length - str2.Length);
    if (errs0 != errs && VerboseLevel > 1)
    {
      Console.WriteLine($"  Errors:");
      foreach (var error in errors)
        Console.WriteLine($"    {error}");
    }
    return str.Length;
  }
}