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

    //count += TestCharLongNamesLike("*VULGAR FRACTION*", ref failed, options);
    //count += TestCharLongNamesLike("*CHESS*", ref failed, options);
    //count += TestCharLongNamesLike("*VARIATION SELECTOR*", ref failed, options);
    //count += TestCharLongNamesLike("*BOX DRAWINGS*", ref failed, options);
    count += TestCharLongNamesLike("*SIGNWRITING*", ref failed, options);

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
  //private int TestCharNamesInRange(char from, char to, ref int errs, TextOptions options)
  //{
  //  char[] chars = new char[to-from+1];
  //  for (int i = from; i <= to; i++)
  //  {
  //    chars[i-from] = (char)i;
  //  }
  //  string text = new string(chars);
  //  var count = TestCharNames(text, ref errs,options);
  //  return count;
  //}

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