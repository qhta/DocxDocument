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
    //count += TestCharNamesInRange(0x0590, 0x05FF, ref failed, options); // Hebrew
    //count += TestCharNamesInRange(0x0600, 0x06FF, ref failed, options); // Arabic
    //count += TestCharNamesInRange(0x0700, 0x074F, ref failed, options); // Syriac
    //count += TestCharNamesInRange(0x0750, 0x077F, ref failed, options); // Arabic Supplement
    //count += TestCharNamesInRange(0x0780, 0x07BF, ref failed, options); // Thaana
    //count += TestCharNamesInRange(0x07C0, 0x07FF, ref failed, options); // NKo
    //count += TestCharNamesInRange(0x0800, 0x083F, ref failed, options); // Samaritan
    //count += TestCharNamesInRange(0x0840, 0x085F, ref failed, options); // Mandaic
    //count += TestCharNamesInRange(0x0860, 0x086F, ref failed, options); // Syriac Supplement
    //count += TestCharNamesInRange(0x0870, 0x089F, ref failed, options); // Arabic Extended-B
    //count += TestCharNamesInRange(0x08A0, 0x08FF, ref failed, options); // Arabic Extended-A
    //count += TestCharNamesInRange(0x0900, 0x097F, ref failed, options); // Devanagari
    //count += TestCharNamesInRange(0x0980, 0x09FF, ref failed, options); // Bengali
    //count += TestCharNamesInRange(0x0A00, 0x0A7F, ref failed, options); // Gurmukhi
    //count += TestCharNamesInRange(0x0A80, 0x0AFF, ref failed, options); // Gujarati
    count += TestCharNamesInRange(0x0B00, 0x0B7F, ref failed, options); // Oriya
    //count += TestCharNamesInRange(0x0B80, 0x0BFF, ref failed, options); // Tamil
    //count += TestCharNamesInRange(0x0C00, 0x0C7F, ref failed, options); // Telugu
    //count += TestCharNamesInRange(0x0C80, 0x0CFF, ref failed, options); // Kannada
    //count += TestCharNamesInRange(0x0D00, 0x0D7F, ref failed, options); // Malayalam
    //count += TestCharNamesInRange(0x0D80, 0x0DFF, ref failed, options); // Sinhala
    //count += TestCharNamesInRange(0x0E00, 0x0E7F, ref failed, options); // Thai
    //count += TestCharNamesInRange(0x0E80, 0x0EFF, ref failed, options); // Lao
    //count += TestCharNamesInRange(0x0F00, 0x0FFF, ref failed, options); // Tibetan
    //count += TestCharNamesInRange(0x1000, 0x109F, ref failed, options); // Myanmar
    //count += TestCharNamesInRange(0x10A0, 0x10FF, ref failed, options); // Georgian
    //count += TestCharNamesInRange(0x1100, 0x11FF, ref failed, options); // Hangul Jamo
    //count += TestCharNamesInRange(0x1200, 0x137F, ref failed, options); // Ethiopic
    //count += TestCharNamesInRange(0x1380, 0x139F, ref failed, options); // Ethiopic Supplement
    //count += TestCharNamesInRange(0x13A0, 0x13FF, ref failed, options); // Cherokee
    //count += TestCharNamesInRange(0x1400, 0x167F, ref failed, options); // Unified Canadian Aboriginal Syllabics
    //count += TestCharNamesInRange(0x1680, 0x169F, ref failed, options); // Ogham
    //count += TestCharNamesInRange(0x16A0, 0x16FF, ref failed, options); // Runic
    //count += TestCharNamesInRange(0x1700, 0x171F, ref failed, options); // Tagalog
    //count += TestCharNamesInRange(0x1720, 0x173F, ref failed, options); // Hanunoo
    //count += TestCharNamesInRange(0x1740, 0x175F, ref failed, options); // Buhid
    //count += TestCharNamesInRange(0x1760, 0x177F, ref failed, options); // Tagbanwa
    //count += TestCharNamesInRange(0x1780, 0x17FF, ref failed, options); // Khmer

    //count += TestCharNamesInRange(0x1800, 0x18AF, ref failed, options); // Mongolian
    //count += TestCharNamesInRange(0x18B0, 0x18FF, ref failed, options); // Unified Canadian Aboriginal Syllabics Extended
    //count += TestCharNamesInRange(0x1900, 0x194F, ref failed, options); // Limbu
    //count += TestCharNamesInRange(0x1950, 0x197F, ref failed, options); // Tai Le
    //count += TestCharNamesInRange(0x1980, 0x19DF, ref failed, options); // New Tai Lue
    //count += TestCharNamesInRange(0x19E0, 0x19FF, ref failed, options); // Khmer Symbols
    //count += TestCharNamesInRange(0x1A00, 0x1A1F, ref failed, options); // Buginese
    //count += TestCharNamesInRange(0x1A20, 0x1AAF, ref failed, options); // Tai Tham
    //count += TestCharNamesInRange(0x1AB0, 0x1AFF, ref failed, options); // Combining Diacritical Marks Extended
    //count += TestCharNamesInRange(0x1B00, 0x1B7F, ref failed, options); // Balinese
    //count += TestCharNamesInRange(0x1B80, 0x1BBF, ref failed, options); // Sundanese
    //count += TestCharNamesInRange(0x1BC0, 0x1BFF, ref failed, options); // Batak
    //count += TestCharNamesInRange(0x1C00, 0x1C4F, ref failed, options); // Lepcha
    //count += TestCharNamesInRange(0x1C50, 0x1C7F, ref failed, options); // Ol Chiki
    //count += TestCharNamesInRange(0x1C80, 0x1C8F, ref failed, options); // Cyrillic Extended-C
    //count += TestCharNamesInRange(0x1C90, 0x1CBF, ref failed, options); // Georgian Extended
    //count += TestCharNamesInRange(0x1CC0, 0x1CCF, ref failed, options); // Sundanese Supplement
    //count += TestCharNamesInRange(0x1CD0, 0x1CFF, ref failed, options); // Vedic Extensions
    //count += TestCharNamesInRange(0x1D00, 0x1D7F, ref failed, options); // Phonetic Extensions
    //count += TestCharNamesInRange(0x1D80, 0x1DBF, ref failed, options); // Phonetic Extensions Supplement
    //count += TestCharNamesInRange(0x1DC0, 0x1DFF, ref failed, options); // Combining Diacritical Marks Supplement
    //count += TestCharNamesInRange(0x1E00, 0x1EFF, ref failed, options); // Latin Extended Additional
    //count += TestCharNamesInRange(0x1F00, 0x1FFF, ref failed, options); // Greek Extended
    //count += TestCharNamesInRange(0x2000, 0x206F, ref failed, options); // General Punctuation
    //count += TestCharNamesInRange(0x2070, 0x209F, ref failed, options); // Superscripts and Subscripts
    //count += TestCharNamesInRange(0x20A0, 0x20CF, ref failed, options); // Currency Symbols
    //count += TestCharNamesInRange(0x20D0, 0x20FF, ref failed, options); // Combining Diacritical Marks for Symbols
    //count += TestCharNamesInRange(0x2100, 0x214F, ref failed, options); // Letterlike Symbols
    //count += TestCharNamesInRange(0x2150, 0x218F, ref failed, options); // Number Forms
    //count += TestCharNamesInRange(0x2190, 0x21FF, ref failed, options); // Arrows
    //count += TestCharNamesInRange(0x2200, 0x22FF, ref failed, options); // Mathematical Operators
    //count += TestCharNamesInRange(0x2300, 0x23FF, ref failed, options); // Miscellaneous Technical
    //count += TestCharNamesInRange(0x2400, 0x243F, ref failed, options); // Control Pictures
    //count += TestCharNamesInRange(0x2440, 0x245F, ref failed, options); // Optical Character Recognition
    //count += TestCharNamesInRange(0x2460, 0x24FF, ref failed, options); // Enclosed Alphanumerics
    //count += TestCharNamesInRange(0x2500, 0x257F, ref failed, options); // Box Drawing
    //count += TestCharNamesInRange(0x2580, 0x259F, ref failed, options); // Block Elements
    //count += TestCharNamesInRange(0x25A0, 0x25FF, ref failed, options); // Geometric Shapes
    //count += TestCharNamesInRange(0x2600, 0x26FF, ref failed, options); // Miscellaneous Symbols
    //count += TestCharNamesInRange(0x2700, 0x27BF, ref failed, options); // Dingbats
    //count += TestCharNamesInRange(0x27C0, 0x27EF, ref failed, options); // Miscellaneous Mathematical Symbols-A
    //count += TestCharNamesInRange(0x27F0, 0x27FF, ref failed, options); // Supplemental Arrows-A

    //count += TestCharNamesInRange(0x2800, 0x28FF, ref failed, options); // Braille Patterns
    //count += TestCharNamesInRange(0x2900, 0x297F, ref failed, options); // Supplemental Arrows-B
    //count += TestCharNamesInRange(0x2980, 0x29FF, ref failed, options); // Miscellaneous Mathematical Symbols-B
    //count += TestCharNamesInRange(0x2A00, 0x2AFF, ref failed, options); // Supplemental Mathematical Operators
    //count += TestCharNamesInRange(0x2B00, 0x2BFF, ref failed, options); // Miscellaneous Symbols and Arrows
    //count += TestCharNamesInRange(0x2C00, 0x2C5F, ref failed, options); // Glagolitic
    //count += TestCharNamesInRange(0x2C60, 0x2C7F, ref failed, options); // Latin Extended-C
    //count += TestCharNamesInRange(0x2C80, 0x2CFF, ref failed, options); // Coptic 
    //count += TestCharNamesInRange(0x2D00, 0x2D2F, ref failed, options); // Georgian Supplement
    //count += TestCharNamesInRange(0x2D30, 0x2D7F, ref failed, options); // Tifinagh
    //count += TestCharNamesInRange(0x2D80, 0x2DDF, ref failed, options); // Ethiopic Extended
    //count += TestCharNamesInRange(0x2DE0, 0x2DFF, ref failed, options); // Cyrillic Extended-A
    //count += TestCharNamesInRange(0x2E00, 0x2E7F, ref failed, options); // Supplemental Punctuation
    //count += TestCharNamesInRange(0x2E80, 0x2EFF, ref failed, options); // CJK Radicals Supplement
    //count += TestCharNamesInRange(0x2F00, 0x2FDF, ref failed, options); // Kangxi Radicals
    //count += TestCharNamesInRange(0x2FF0, 0x2FFF, ref failed, options); // Ideographic Description Characters
    //count += TestCharNamesInRange(0x3000, 0x303F, ref failed, options); // CJK Symbols and Punctuation

    //count += TestCharNamesInRange(0x3040, 0x309F, ref failed, options); // Hiragana
    //count += TestCharNamesInRange(0x30A0, 0x30FF, ref failed, options); // Katakana
    //count += TestCharNamesInRange(0x3100, 0x312F, ref failed, options); // Bopomofo
    //count += TestCharNamesInRange(0x3130, 0x318F, ref failed, options); // Hangul Compatibility Jamo
    //count += TestCharNamesInRange(0x3190, 0x319F, ref failed, options); // Kanbun
    //count += TestCharNamesInRange(0x31A0, 0x31BF, ref failed, options); // Bopomofo Extended
    //count += TestCharNamesInRange(0x31C0, 0x31EF, ref failed, options); // CJK Strokes
    //count += TestCharNamesInRange(0x31F0, 0x31FF, ref failed, options); // Katakana Phonetic Extensions
    //count += TestCharNamesInRange(0x3200, 0x32FF, ref failed, options); // Enclosed CJK Letters and Months
    //count += TestCharNamesInRange(0x3300, 0x33FF, ref failed, options); // CJK Compatibility
    //count += TestCharNamesInRange(0x3400, 0x4DBF, ref failed, options); // CJK Unified Ideographs Extension A
    //count += TestCharNamesInRange(0x4DC0, 0x4DFF, ref failed, options); // Yijing Hexagram Symbols
    //count += TestCharNamesInRange(0x4E00, 0x9FFF, ref failed, options); // CJK Unified Ideographs
    //count += TestCharNamesInRange(0xA000, 0xA48F, ref failed, options); // Yi Syllables
    //count += TestCharNamesInRange(0xA490, 0xA4CF, ref failed, options); // Yi Radicals
    //count += TestCharNamesInRange(0xA4D0, 0xA4FF, ref failed, options); // Lisu
    //count += TestCharNamesInRange(0xA500, 0xA63F, ref failed, options); // Vai
    //count += TestCharNamesInRange(0xA640, 0xA69F, ref failed, options); // Cyrillic Extended-B
    //count += TestCharNamesInRange(0xA6A0, 0xA6FF, ref failed, options); // Bamum
    //count += TestCharNamesInRange(0xA700, 0xA71F, ref failed, options); // Modifier Tone Letters
    //count += TestCharNamesInRange(0xA720, 0xA7FF, ref failed, options); // Latin Extended-D
    //count += TestCharNamesInRange(0xA800, 0xA82F, ref failed, options); // Syloti Nagri
    //count += TestCharNamesInRange(0xA830, 0xA83F, ref failed, options); // Common Indic Number Forms
    //count += TestCharNamesInRange(0xA840, 0xA87F, ref failed, options); // Phags-pa
    //count += TestCharNamesInRange(0xA880, 0xA8DF, ref failed, options); // Saurashtra
    //count += TestCharNamesInRange(0xA8E0, 0xA8FF, ref failed, options); // Devanagari Extended
    //count += TestCharNamesInRange(0xA900, 0xA92F, ref failed, options); // Kayah Li
    //count += TestCharNamesInRange(0xA930, 0xA95F, ref failed, options); // Rejang
    //count += TestCharNamesInRange(0xA960, 0xA97F, ref failed, options); // Hangul Jamo Extended-A
    //count += TestCharNamesInRange(0xA980, 0xA9DF, ref failed, options); // Javanese
    //count += TestCharNamesInRange(0xA9E0, 0xA9FF, ref failed, options); // Myanmar Extended-B
    //count += TestCharNamesInRange(0xAA00, 0xAA5F, ref failed, options); // Cham
    //count += TestCharNamesInRange(0xAA60, 0xAA7F, ref failed, options); // Myanmar Extended-A
    //count += TestCharNamesInRange(0xAA80, 0xAADF, ref failed, options); // Tai Viet
    //count += TestCharNamesInRange(0xAAE0, 0xAAFF, ref failed, options); // Meetei Mayek Extensions
    //count += TestCharNamesInRange(0xAB00, 0xAB2F, ref failed, options); // Ethiopic Extended-A
    //count += TestCharNamesInRange(0xAB30, 0xAB6F, ref failed, options); // Latin Extended-E
    //count += TestCharNamesInRange(0xAB70, 0xABBF, ref failed, options); // Cherokee Supplement
    //count += TestCharNamesInRange(0xABC0, 0xABFF, ref failed, options); // Meetei Mayek

    //count += TestCharNamesInRange(0xAC00, 0xD7AF, ref failed, options); // Hangul Syllables
    //count += TestCharNamesInRange(0xD7B0, 0xD7FF, ref failed, options); // Hangul Jamo Extended-B
    //count += TestCharNamesInRange(0xD800, 0xDB7F, ref failed, options); // High Surrogates
    //count += TestCharNamesInRange(0xDB80, 0xDBFF, ref failed, options); // High Private Use Surrogates
    //count += TestCharNamesInRange(0xDC00, 0xDFFF, ref failed, options); // Low Surrogates
    //count += TestCharNamesInRange(0xE000, 0xF8FF, ref failed, options); // Private Use Area
    //count += TestCharNamesInRange(0xF900, 0xFAFF, ref failed, options); // CJK Compatibility Ideographs
    //count += TestCharNamesInRange(0xFB00, 0xFB4F, ref failed, options); // Alphabetic Presentation Forms
    //count += TestCharNamesInRange(0xFB50, 0xFDFF, ref failed, options); // Arabic Presentation Forms-A
    //count += TestCharNamesInRange(0xFE00, 0xFE0F, ref failed, options); // Variation Selectors
    //count += TestCharNamesInRange(0xFE10, 0xFE1F, ref failed, options); // Vertical Forms
    //count += TestCharNamesInRange(0xFE20, 0xFE2F, ref failed, options); // Combining Half Marks
    //count += TestCharNamesInRange(0xFE30, 0xFE4F, ref failed, options); // CJK Compatibility Forms
    //count += TestCharNamesInRange(0xFE50, 0xFE6F, ref failed, options); // Small Form Variants
    //count += TestCharNamesInRange(0xFE70, 0xFEFF, ref failed, options); // Arabic Presentation Forms-B
    //count += TestCharNamesInRange(0xFF00, 0xFFEF, ref failed, options); // Halfwidth and Fullwidth Forms
    //count += TestCharNamesInRange(0xFFF0, 0xFFFF, ref failed, options); // Specials

    //count += TestCharNamesInRange(0x10000, 0x1007F, ref failed, options); // Linear B Syllabary
    //count += TestCharNamesInRange(0x10080, 0x100FF, ref failed, options); // Linear B Ideograms
    //count += TestCharNamesInRange(0x10100, 0x1013F, ref failed, options); // Aegean Numbers
    //count += TestCharNamesInRange(0x10140, 0x1018F, ref failed, options); // Ancient Greek Numbers
    //count += TestCharNamesInRange(0x10190, 0x101CF, ref failed, options); // Ancient Symbols
    //count += TestCharNamesInRange(0x101D0, 0x101FF, ref failed, options); // Phaistos Disc
    //count += TestCharNamesInRange(0x10280, 0x1029F, ref failed, options); // Lycian
    //count += TestCharNamesInRange(0x102A0, 0x102DF, ref failed, options); // Carian
    //count += TestCharNamesInRange(0x102E0, 0x102FF, ref failed, options); // Coptic Epact Numbers

    //count += TestCharNamesInRange(0x10300, 0x1032F, ref failed, options); // Old Italic
    //count += TestCharNamesInRange(0x10330, 0x1034F, ref failed, options); // Gothic
    //count += TestCharNamesInRange(0x10350, 0x1037F, ref failed, options); // Old Permic
    //count += TestCharNamesInRange(0x10380, 0x1039F, ref failed, options); // Ugaritic
    //count += TestCharNamesInRange(0x103A0, 0x103DF, ref failed, options); // Old Persian
    //count += TestCharNamesInRange(0x10400, 0x1044F, ref failed, options); // Deseret
    //count += TestCharNamesInRange(0x10450, 0x1047F, ref failed, options); // Shavian
    //count += TestCharNamesInRange(0x10480, 0x104AF, ref failed, options); // Osmanya
    //count += TestCharNamesInRange(0x104B0, 0x104FF, ref failed, options); // Osage
    //count += TestCharNamesInRange(0x10500, 0x1052F, ref failed, options); // Elbasan
    //count += TestCharNamesInRange(0x10530, 0x1056F, ref failed, options); // Caucasian Albanian

    //count += TestCharNamesInRange(0x10570, 0x105BC, ref failed, options); // Vithkuqi
    //count += TestCharNamesInRange(0x105C0, 0x105FF, ref failed, options); // Todhri
    //count += TestCharNamesInRange(0x10600, 0x1077F, ref failed, options); // Linear A
    //count += TestCharNamesInRange(0x10780, 0x107CF, ref failed, options); // Latin Extended-F
    //count += TestCharNamesInRange(0x10800, 0x1083F, ref failed, options); // Cypriot Syllabary
    //count += TestCharNamesInRange(0x10840, 0x1085F, ref failed, options); // Imperial Aramaic
    //count += TestCharNamesInRange(0x10860, 0x1087F, ref failed, options); // Palmyrene
    //count += TestCharNamesInRange(0x10880, 0x108AF, ref failed, options); // Nabataean
    //count += TestCharNamesInRange(0x108E0, 0x108FF, ref failed, options); // Hatran
    //count += TestCharNamesInRange(0x10900, 0x1091F, ref failed, options); // Phoenician
    //count += TestCharNamesInRange(0x10920, 0x1093F, ref failed, options); // Lydian
    //count += TestCharNamesInRange(0x10980, 0x1099F, ref failed, options); // Meroitic Hieroglyphs
    //count += TestCharNamesInRange(0x109A0, 0x109FF, ref failed, options); // Meroitic Cursive
    //count += TestCharNamesInRange(0x10A00, 0x10A5F, ref failed, options); // Kharoshthi
    //count += TestCharNamesInRange(0x10A60, 0x10A7F, ref failed, options); // Old South Arabian
    //count += TestCharNamesInRange(0x10A80, 0x10A9F, ref failed, options); // Old North Arabian
    //count += TestCharNamesInRange(0x10AC0, 0x10AFF, ref failed, options); // Manichaean
    //count += TestCharNamesInRange(0x10B00, 0x10B3F, ref failed, options); // Avestan
    //count += TestCharNamesInRange(0x10B40, 0x10B5F, ref failed, options); // Inscriptional Parthian
    //count += TestCharNamesInRange(0x10B60, 0x10B7F, ref failed, options); // Inscriptional Pahlavi
    //count += TestCharNamesInRange(0x10B80, 0x10BAF, ref failed, options); // Psalter Pahlavi
    //count += TestCharNamesInRange(0x10C00, 0x10C4F, ref failed, options); // Old Turkic
    //count += TestCharNamesInRange(0x10C80, 0x10CFF, ref failed, options); // Old Hungarian
    //count += TestCharNamesInRange(0x10D00, 0x10D3F, ref failed, options); // Hanifi Rohingya
    //count += TestCharNamesInRange(0x10D40, 0x10D8F, ref failed, options); // Garay
    //count += TestCharNamesInRange(0x10E60, 0x10E7F, ref failed, options); // Rumi Numeral Symbols
    //count += TestCharNamesInRange(0x10E80, 0x10EBF, ref failed, options); // Yezidi
    //count += TestCharNamesInRange(0x10EC0, 0x10EFF, ref failed, options); // Arabic Extended-C
    //count += TestCharNamesInRange(0x10F00, 0x10F2F, ref failed, options); // Old Sogdian
    //count += TestCharNamesInRange(0x10F30, 0x10F6F, ref failed, options); // Sogdian
    //count += TestCharNamesInRange(0x10F70, 0x10FAF, ref failed, options); // Old Uyghur
    //count += TestCharNamesInRange(0x10FB0, 0x10FDF, ref failed, options); // Chorasmian
    //count += TestCharNamesInRange(0x10FE0, 0x10FFF, ref failed, options); // Elymaic
    //count += TestCharNamesInRange(0x11000, 0x1107F, ref failed, options); // Brahmi
    //count += TestCharNamesInRange(0x11080, 0x110CF, ref failed, options); // Kaithi
    //count += TestCharNamesInRange(0x110D0, 0x110FF, ref failed, options); // Sora Sompeng
    //count += TestCharNamesInRange(0x11100, 0x1114F, ref failed, options); // Chakma
    //count += TestCharNamesInRange(0x11150, 0x1117F, ref failed, options); // Mahajani
    //count += TestCharNamesInRange(0x11180, 0x111DF, ref failed, options); // Sharada
    //count += TestCharNamesInRange(0x111E0, 0x111FF, ref failed, options); // Sinhala Archaic Numbers
    //count += TestCharNamesInRange(0x11200, 0x1124F, ref failed, options); // Khojki
    //count += TestCharNamesInRange(0x11280, 0x112AF, ref failed, options); // Multani
    //count += TestCharNamesInRange(0x112B0, 0x112FF, ref failed, options); // Khudawadi
    //count += TestCharNamesInRange(0x11300, 0x1137F, ref failed, options); // Grantha
    //count += TestCharNamesInRange(0x11380, 0x113FF, ref failed, options); // Tulu-Tigalari
    //count += TestCharNamesInRange(0x11400, 0x1147F, ref failed, options); // Newa
    //count += TestCharNamesInRange(0x11480, 0x114DF, ref failed, options); // Tirhuta
    //count += TestCharNamesInRange(0x11580, 0x115FF, ref failed, options); // Siddham
    //count += TestCharNamesInRange(0x11600, 0x1165F, ref failed, options); // Modi
    //count += TestCharNamesInRange(0x11660, 0x1167F, ref failed, options); // Mongolian Supplement
    //count += TestCharNamesInRange(0x11680, 0x116CF, ref failed, options); // Takri
    //count += TestCharNamesInRange(0x116D0, 0x116FF, ref failed, options); // Myanmar Extended-C
    //count += TestCharNamesInRange(0x11700, 0x1173F, ref failed, options); // Ahom
    //count += TestCharNamesInRange(0x11800, 0x1184F, ref failed, options); // Dogra
    //count += TestCharNamesInRange(0x118A0, 0x118FF, ref failed, options); // Warang Citi
    //count += TestCharNamesInRange(0x11900, 0x1195F, ref failed, options); // Dives Akuru
    //count += TestCharNamesInRange(0x119A0, 0x119FF, ref failed, options); // Nandinagari
    //count += TestCharNamesInRange(0x11A00, 0x11A4F, ref failed, options); // Zanabazar Square
    //count += TestCharNamesInRange(0x11A50, 0x11AAF, ref failed, options); // Soyombo
    //count += TestCharNamesInRange(0x11AB0, 0x11ABF, ref failed, options); // Soyombo
    //count += TestCharNamesInRange(0x11AC0, 0x11AFF, ref failed, options); // Pau Cin Hau
    //count += TestCharNamesInRange(0x11B00, 0x11B5F, ref failed, options); // Devanagari Extended-A
    //count += TestCharNamesInRange(0x11BC0, 0x11BFF, ref failed, options); // Sunuwar
    //count += TestCharNamesInRange(0x11C00, 0x11C6F, ref failed, options); // Bhaiksuki
    //count += TestCharNamesInRange(0x11C70, 0x11CBF, ref failed, options); // Marchen
    //count += TestCharNamesInRange(0x11D00, 0x11D5F, ref failed, options); // Masaram Gondi
    //count += TestCharNamesInRange(0x11D60, 0x11DAF, ref failed, options); // Gunjala Gondi
    //count += TestCharNamesInRange(0x11EE0, 0x11EFF, ref failed, options); // Makasar
    //count += TestCharNamesInRange(0x11F00, 0x11F5F, ref failed, options); // Kawi
    //count += TestCharNamesInRange(0x11FB0, 0x11FBF, ref failed, options); // Lisu Supplement
    //count += TestCharNamesInRange(0x11FC0, 0x11FFF, ref failed, options); // Tamil Supplement
    //count += TestCharNamesInRange(0x12000, 0x123FF, ref failed, options); // Cuneiform
    //count += TestCharNamesInRange(0x12400, 0x1247F, ref failed, options); // Cuneiform Numbers and Punctuation
    //count += TestCharNamesInRange(0x12480, 0x1254F, ref failed, options); // Early Dynastic Cuneiform
    //count += TestCharNamesInRange(0x12F90, 0x125FF, ref failed, options); // Cypro-Minoan
    //count += TestCharNamesInRange(0x13000, 0x1342F, ref failed, options); // Egyptian Hieroglyphs
    //count += TestCharNamesInRange(0x13430, 0x1343F, ref failed, options); // Egyptian Hieroglyph Format Controls
    //count += TestCharNamesInRange(0x13460, 0x1355F, ref failed, options); // Egyptian Hieroglyph Extended-A
    //count += TestCharNamesInRange(0x14400, 0x1467F, ref failed, options); // Anatolian Hieroglyphs
    //count += TestCharNamesInRange(0x16100, 0x1613F, ref failed, options); // Gurung Khema
    //count += TestCharNamesInRange(0x16800, 0x16A3F, ref failed, options); // Bamum Supplement
    //count += TestCharNamesInRange(0x16A40, 0x16A6F, ref failed, options); // Mro
    //count += TestCharNamesInRange(0x16A00, 0x16ACF, ref failed, options); // Mro
    //count += TestCharNamesInRange(0x16AD0, 0x16AFF, ref failed, options); // Bassa Vah
    //count += TestCharNamesInRange(0x16B00, 0x16B8F, ref failed, options); // Pahawh Hmong
    //count += TestCharNamesInRange(0x16D40, 0x16D7F, ref failed, options); // Kirat Rai
    //count += TestCharNamesInRange(0x16E40, 0x16E9F, ref failed, options); // Medefaidrin
    //count += TestCharNamesInRange(0x16F00, 0x16F9F, ref failed, options); // Miao
    //count += TestCharNamesInRange(0x16FE0, 0x16FFF, ref failed, options); // Ideographic Symbols and Punctuation
    //count += TestCharNamesInRange(0x17000, 0x187FF, ref failed, options); // Tangut
    //count += TestCharNamesInRange(0x18800, 0x18AFF, ref failed, options); // Tangut Components
    //count += TestCharNamesInRange(0x18B00, 0x18BFF, ref failed, options); // Kithan Small Script
    //count += TestCharNamesInRange(0x18D00, 0x18D08, ref failed, options); // Tangut Supplement
    //count += TestCharNamesInRange(0x1AFF0, 0x1AFFF, ref failed, options); // Kana Extended-B
    //count += TestCharNamesInRange(0x1B000, 0x1B0FF, ref failed, options); // Kana Supplement
    //count += TestCharNamesInRange(0x1B100, 0x1B12F, ref failed, options); // Kana Extended-A
    //count += TestCharNamesInRange(0x1B130, 0x1B16F, ref failed, options); // Small Kana Extension
    //count += TestCharNamesInRange(0x1B170, 0x1B2FF, ref failed, options); // Nushu
    //count += TestCharNamesInRange(0x1BC00, 0x1BC9F, ref failed, options); // Duployan
    //count += TestCharNamesInRange(0x1BCA0, 0x1BCAF, ref failed, options); // Shorthand Format Controls
    //count += TestCharNamesInRange(0x1CC00, 0x1CCEF, ref failed, options); // Symbols for Legacy Computing Supplement
    //count += TestCharNamesInRange(0x1CF00, 0x1CFCF, ref failed, options); // Znamenny Musical Notation
    //count += TestCharNamesInRange(0x1D000, 0x1D0FF, ref failed, options); // Byzantine Musical Symbols







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