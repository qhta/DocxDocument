using System;
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
    //var points = ucd.SearchInNames("SUPERSCRIPT*").ToList();
    //foreach (var point in points)
    //{
    //  var charInfo = ucd[point];
    //  if (VerboseLevel > 0)
    //    Console.WriteLine($"{charInfo.CodePoint} {charInfo.Name}");

    //}
    //Console.WriteLine($"Found {points.Count()} points");
    //return;
    if (VerboseLevel > 0)
      Console.WriteLine($"\nTest {options.Mode} characters encoding");

    count += TestCharEncoding(body, UnicodeCategory.Control, ref failed, options);
    count += TestCharEncoding(body, [UnicodeCategory.SpaceSeparator, UnicodeCategory.ParagraphSeparator, UnicodeCategory.LineSeparator], ref failed, options);
    count += TestCharEncoding(body, '\x20', '\x7E', ref failed, options);
    count += TestCharEncoding(body, '\xA1','\xFF', ref failed, options);
    count += TestCharEncoding(body, UnicodeCategory.DashPunctuation, ref failed, options);
    count += TestCharEncoding(body, UnicodeCategory.Format, ref failed, options);
    count += TestCharEncoding(body, UnicodeCategory.ModifierSymbol, ref failed, options);
    count += TestCharEncoding(body, UnicodeCategory.NonSpacingMark, ref failed, options);
    count += TestCharEncoding(body, CharUtils.SupChars, ref failed, options);
    count += TestCharEncoding(body, CharUtils.SubChars, ref failed, options);
    count += TestCharEncoding(body, CharUtils.RomanChars, ref failed, options);
    if (VerboseLevel > 0)
    {
      int passed = count - failed;
      Console.WriteLine($" {passed} chars tests passed.");
      Console.WriteLine($" {failed} chars tests failed.");
    }
  }

  private int TestCharEncoding(DX.OpenXmlCompositeElement body, UnicodeCategory ctg, ref int errs, TextOptions options)
  {
    var sb = new StringBuilder();
    for (int i = 0; i <= 0xFFFF; i++)
    {
      var ch = (char)i;
      if (Char.GetUnicodeCategory(ch) == ctg)
        sb.Append(ch);
    }
    string text = sb.ToString();
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }

  private int TestCharEncoding(DX.OpenXmlCompositeElement body, UnicodeCategory[] ctgs, ref int errs, TextOptions options)
  {
    var sb = new StringBuilder();
    for (int i = 0; i <= 0xFFFF; i++)
    {
      var ch = (char)i;
      if (ctgs.Contains(Char.GetUnicodeCategory(ch)))
        sb.Append(ch);
    }
    string text = sb.ToString();
    var count = TestCharEncoding(body, text, ref errs, options);
    return count;
  }

  private int TestCharEncoding(DX.OpenXmlCompositeElement body, char from, char to, ref int errs, TextOptions options)
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

  private int TestCharEncoding(DX.OpenXmlCompositeElement body, char[] values, ref int errs, TextOptions options)
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