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
  /// Run a test of Unicode char names
  /// </summary>
  public void TestCharNames()
  {
    TextOptions options = TextOptions.RichText;
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
      Console.WriteLine($"\nTest characters names");

    //count += TestCharNamesInCategory(UcdCategory.Cc, ref failed, options);
    //count += TestCharNamesInCategories("Z", ref failed, options);
    //count += TestCharNamesInRange('\x20', '\x7E', ref failed, options);
    //count += TestCharNamesInRange('\xA1','\xFF', ref failed, options);
    //count += TestCharNamesInCategory(UcdCategory.Pd, ref failed, options);
    //count += TestCharNamesInCategory(UcdCategory.Cf, ref failed, options);
    //count += TestCharNamesInCategory(UcdCategory.Sk, ref failed, options);
    //count += TestCharNamesInCategory(UcdCategory.Mn, ref failed, options);
    //count += TestCharNamesInSet(CharUtils.SupChars, ref failed, options);
    //count += TestCharNamesInSet(CharUtils.SubChars, ref failed, options);
    //count += TestCharNamesInSet(CharUtils.RomanChars, ref failed, options);
    //count += TestCharNamesInScript("Latin", ref failed, options);

    //count += TestCharLongNamesLike("*ARROW*", ref failed, options);
    // += TestCharLongNamesLike("*HARPOON*", ref failed, options);

    //count += TestCharNamesInBlock("Wide-Headed Arrows", ref failed, options);
    //count += TestCharLongNamesLike("*ARAB*", ref failed, options);

    //count += TestCharLongNamesLike("*VAI*", ref failed, options);
    //count += TestCharLongNamesLike("*VEDIC*", ref failed, options);
    //count += TestCharLongNamesLike("*VITHKUQI*", ref failed, options);
    //count += TestCharLongNamesLike("*WANCHO*", ref failed, options);
    //count += TestCharLongNamesLike("*WARANG*", ref failed, options);

    //count += TestCharLongNamesLike("*CHESS*", ref failed, options);
    //count += TestCharLongNamesLike("*VULGAR FRACTION*", ref failed, options);
    //count += TestCharLongNamesLike("*VARIATION SELECTOR*", ref failed, options);
    //count += TestCharLongNamesLike("*BOX DRAWINGS*", ref failed, options);


    //count += TestCharLongNamesLike("*SIGNWRITING*", ref failed, options);
    //count += TestCharLongNamesLike("WIDE-HEADED*", ref failed, options);
    //count += TestCharLongNamesLike("XIANGQI*", ref failed, options);
    //count += TestCharLongNamesLike("YEZIDI*", ref failed, options);
    //count += TestCharLongNamesLike("YI *", ref failed, options);
    //count += TestCharLongNamesLike("Z NOTATION*", ref failed, options);
    //count += TestCharLongNamesLike("ZANABAZAR*", ref failed, options);
    //count += TestCharLongNamesLike("ZNAMENNY*", ref failed, options);
    //count += TestCharLongNamesLike("EXTENDED ARABIC-INDIC*", ref failed, options);
    //count += TestCharLongNamesLike("HALFWIDTH*", ref failed, options);
    //count += TestCharLongNamesLike("FULLWIDTH*", ref failed, options);

    //count += TestCharNamesInRange(0x0000, 0x007F, ref failed, options); // Basic Latin
    //count += TestCharNamesInRange(0x0080, 0x00FF, ref failed, options); // Latin-1 Supplement
    //count += TestCharNamesInRange(0x0100, 0x017F, ref failed, options); // Latin Extended-A
    //count += TestCharNamesInRange(0x0180, 0x024F, ref failed, options); // Latin Extended-B
    //count += TestCharNamesInRange(0x0250, 0x02AF, ref failed, options); // IPA Extensions
    //count += TestCharNamesInRange(0x02B0, 0x02FF, ref failed, options); // Spacing Modifier Letters
    //count += TestCharNamesInRange(0x0300, 0x036F, ref failed, options); // Combining Diacritical Marks
    //count += TestCharNamesInRange(0x0370, 0x03FF, ref failed, options); // Greek and Coptic
    //count += TestCharNamesInRange(0x0400, 0x04FF, ref failed, options); // Cyrillic
    //count += TestCharNamesInRange(0x0500, 0x052F, ref failed, options); // Cyrillic Supplement
    //count += TestCharNamesInRange(0x0530, 0x058F, ref failed, options); // Armenian
    count += TestCharNamesInRange(0x0590, 0x05FF, ref failed, options); // Hebrew
    //count += TestCharNamesInRange(0x0600, 0x06FF, ref failed, options); // Arabic
    //count += TestCharNamesInRange(0x0700, 0x074F, ref failed, options); // Syriac
    //count += TestCharNamesInRange(0x0750, 0x077F, ref failed, options); // Arabic Supplement
    //count += TestCharNamesInRange(0x0780, 0x07BF, ref failed, options); // Thaana
    //count += TestCharNamesInRange(0x07C0, 0x07FF, ref failed, options); // NKo
    //count += TestCharNamesInRange(0x0800, 0x083F, ref failed, options); // Samaritan
    //count += TestCharNamesInRange(0x0840, 0x085F, ref failed, options); // Mandaic
    //count += TestCharNamesInRange(0x0860, 0x086F, ref failed, options); // Syriac Supplement
    //count += TestCharNamesInRange(0x0870, 0x089F, ref failed, options); // Thaana
    //count += TestCharNamesInRange(0x08A0, 0x08FF, ref failed, options); // Arabic Extended-A
    //count += TestCharNamesInRange(0x0900, 0x097F, ref failed, options); // Devanagari


    //count += TestCharNamesInRange(0xFF00, 0xFFEF, ref failed, options);

    //count += TestCharNamesInRange(0x1FA70, 0x1FAFF, ref failed, options);
    //count += TestCharNamesInRange(0x1FB00, 0x1FBFF, ref failed, options);

    if (VerboseLevel > 0)
    {
      int passed = count - failed;
      Console.WriteLine($" {passed} chars tests passed.");
      Console.WriteLine($" {failed} chars tests failed.");
    }
  }

  //private int TestCharNamesInCategory(UcdCategory ctg, ref int errs, TextOptions options)
  //{
  //  var sb = new StringBuilder();
  //  foreach (var codePoint in UnicodeData.Instance.SearchInCategories(ctg.ToString()))
  //  {
  //    if (codePoint<=0xFFFF)
  //    {
  //      var ch = (char)codePoint;
  //      sb.Append(ch);
  //    }
  //  }
  //  string text = sb.ToString();
  //  var count = TestCharNames(text, ref errs, options);
  //  return count;
  //}

  //private int TestCharNamesInCategories(string pattern, ref int errs, TextOptions options)
  //{
  //  var sb = new StringBuilder();
  //  foreach (var codePoint in UnicodeData.Instance.SearchInCategories(pattern))
  //  {
  //    if (codePoint <= 0xFFFF)
  //    {
  //      var ch = (char)codePoint;
  //      sb.Append(ch);
  //    }
  //  }
  //  string text = sb.ToString();
  //  var count = TestCharNames(text, ref errs, options);
  //  return count;
  //}

  //private int TestCharNamesInScript(string script, ref int errs, TextOptions options)
  //{
  //  if (ScriptCodes.UcdScriptNames.TryGetValue1(script, out var scriptCode))
  //    script = scriptCode;
  //  var sb = new StringBuilder();
  //  foreach (var codePoint in UnicodeData.Instance.SearchInScripts(script))
  //  {
  //    if (codePoint <= 0xFFFF)
  //    {
  //      var ch = (char)codePoint;
  //      sb.Append(ch);
  //    }
  //  }
  //  string text = sb.ToString();
  //  var count = TestCharNames(text, ref errs, options);
  //  return count;
  //}

  private int TestCharNamesInRange(CodePoint from, CodePoint to, ref int errs, TextOptions options)
  {
    var codePoints = new List<CodePoint>();
    for (int i = from; i <= to; i++)
    {
      codePoints.Add(i);
    }
    var count = TestCharNames(codePoints, ref errs, options);
    return count;
  }

  //private int TestCharNamesInSet(char[] values, ref int errs, TextOptions options)
  //{
  //  char[] chars = new char[values.Length];
  //  for (int i = 0; i < values.Length; i++)
  //  {
  //    chars[i] = (char)values[i];
  //  }
  //  string text = new string(chars);
  //  var count = TestCharNames(text, ref errs, options);
  //  return count;
  //}

  private int TestCharNamesInBlock(string blockName, ref int errs, TextOptions options)
  {
    var codePoints = new List<CodePoint>();
    var ucd = UnicodeData.Instance;
    foreach (var namedBlock in ucd.NamedBlocks.Where(entry=>entry.Name==blockName))
    {
      for (int cp = namedBlock.Start; cp <= namedBlock.End; cp++)
      {
        if (ucd.TryGetValue(cp, out var charInfo) && namedBlock.Contains(cp, charInfo.Name))
          codePoints.Add(cp);
      }
    }
    var count = TestCharNames(codePoints, ref errs, options);
    return count;
  }

  private int TestCharLongNamesLike(string nameStart, ref int errs, TextOptions options)
  {
    var codePoints = new List<CodePoint>();
    var ucd = UnicodeData.Instance;
    foreach (var ch in ucd.Keys)
    {
      if (ucd.TryGetValue(ch, out var charInfo) && charInfo.Name.IsLike(nameStart))
        codePoints.Add(ch);
    }
    var count = TestCharNames(codePoints, ref errs, options);
    return count;
  }

  private int TestCharNames(List<CodePoint> str, ref int errs, TextOptions options)
  {
    int errs0 = errs;
    foreach (var ch in str)
    {
      var ucd = UnicodeData.Instance;
      if (ucd.TryGetValue(ch, out var charInfo) && ucd.CharNameIndex.TryGetValue(ch, out var charName))
        Console.WriteLine($"  {charInfo.CodePoint}:{charName}");
    }
    return str.Count;
  }
}