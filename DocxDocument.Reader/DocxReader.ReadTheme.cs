using DocxDocument.Model;

using DM = DocxDocument.Model;
using DR = DocumentFormat.OpenXml.Drawing;


namespace DocxDocument.Reader;

public partial class DocxReader
{
  public static DM.Theme ReadTheme(DR.Theme? docTheme)
  {
    var dmTheme = new DM.Theme();
    if (docTheme == null)
      return dmTheme;
    if (docTheme.ThemeElements != null)
    {
      foreach (var item in docTheme.ThemeElements)
      {
        if (item is DR.FontScheme docFontScheme)
        {
          var dmFontScheme = ReadFontScheme(docFontScheme);
          dmTheme.Add(dmFontScheme);
        }
      }
    }
    return dmTheme;
  }

  public static DM.FontScheme ReadFontScheme(DR.FontScheme docfontScheme)
  {
    var dmFontScheme = new DM.FontScheme();
    dmFontScheme.Name = docfontScheme.Name;
    if (docfontScheme.MajorFont != null)
      dmFontScheme.MajorFont = ReadFontCollection(docfontScheme.MajorFont);
    if (docfontScheme.MinorFont != null)
      dmFontScheme.MinorFont = ReadFontCollection(docfontScheme.MinorFont);
    return dmFontScheme;
  }

  public static DM.FontCollection ReadFontCollection(DR.FontCollectionType docFontCollection)
  {
    var dmFontCollection = new DM.FontCollection();
    if (docFontCollection.LatinFont != null)
      dmFontCollection.LatinFont = ReadFontSpec(docFontCollection.LatinFont);
    if (docFontCollection.ComplexScriptFont != null)
      dmFontCollection.ComplexScriptFont = ReadFontSpec(docFontCollection.ComplexScriptFont);
    if (docFontCollection.EastAsianFont != null)
      dmFontCollection.EastAsianFont = ReadFontSpec(docFontCollection.EastAsianFont);
    foreach (var drFontSpec in docFontCollection.Elements().OfType<DR.SupplementalFont>())
    {
      var dmFontSpec = ReadFontSpec(drFontSpec);
      if (dmFontSpec.Script!=null)
        dmFontCollection.Add(dmFontSpec);
    }
    return dmFontCollection;
  }

  public static DM.FontSpec ReadFontSpec(DR.TextFontType docFontType)
  {
    var dmFontSpec = new DM.FontSpec();
    dmFontSpec.Typeface = docFontType.Typeface?.Value;
    dmFontSpec.Panose = docFontType.Panose?.Value;
    dmFontSpec.Charset = ((byte?)docFontType.CharacterSet?.Value);
    dmFontSpec.Pitch = ((FontPitch?)docFontType.PitchFamily?.Value);
    return dmFontSpec;
  }

  public static DM.FontSpec ReadFontSpec(DR.SupplementalFont docSupplementalFont)
  {
    var dmFontSpec = new DM.FontSpec();
    dmFontSpec.Script = docSupplementalFont.Script?.Value;
    dmFontSpec.Typeface = docSupplementalFont.Typeface?.Value;
    return dmFontSpec;
  }

}