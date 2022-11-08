using DocxDocument.Model;

using DM = DocxDocument.Model;
using WP = DocumentFormat.OpenXml.Wordprocessing;
using DR = DocumentFormat.OpenXml.Drawing;
using DMR = DocxDocument.Model.Drawing;
using DocumentFormat.OpenXml.Packaging;

namespace DocxDocument.Reader;

public partial class DocxReader
{
  public DMR.Theme ReadDocumentTheme(DR.Theme? wpTheme)
  {
    var dmTheme = new DMR.Theme();
    if (wpTheme == null)
      return dmTheme;
    if (wpTheme.ThemeElements != null)
    {
      foreach (var item in wpTheme.ThemeElements)
      {
        if (item is DR.FontScheme drFontScheme)
        {
          var dmFontScheme = ReadFontScheme(drFontScheme);
          dmTheme.Add(dmFontScheme);
        }
      }
    }
    return dmTheme;
  }

  private DMR.FontScheme ReadFontScheme(DR.FontScheme drfontScheme)
  {
    var dmFontScheme = new DMR.FontScheme();
    dmFontScheme.Name = drfontScheme.Name;
    if (drfontScheme.MajorFont != null)
      dmFontScheme.MajorFont = ReadFontCollection(drfontScheme.MajorFont);
    if (drfontScheme.MinorFont != null)
      dmFontScheme.MinorFont = ReadFontCollection(drfontScheme.MinorFont);
    return dmFontScheme;
  }

  private DMR.FontCollection ReadFontCollection(DR.FontCollectionType drFontCollection)
  {
    var dmFontCollection = new DMR.FontCollection();
    if (drFontCollection.LatinFont != null)
      dmFontCollection.LatinFont = ReadFontSpec(drFontCollection.LatinFont);
    if (drFontCollection.ComplexScriptFont != null)
      dmFontCollection.ComplexScriptFont = ReadFontSpec(drFontCollection.ComplexScriptFont);
    if (drFontCollection.EastAsianFont != null)
      dmFontCollection.EastAsianFont = ReadFontSpec(drFontCollection.EastAsianFont);
    foreach (var drFontSpec in drFontCollection.Elements().OfType<DR.SupplementalFont>())
    {
      var dmFontSpec = ReadFontSpec(drFontSpec);
      if (dmFontSpec.Script!=null)
        dmFontCollection.Add(dmFontSpec);
    }
    return dmFontCollection;
  }

  private DM.FontSpec ReadFontSpec(DR.TextFontType drFontType)
  {
    var dmFontSpec = new DM.FontSpec();
    dmFontSpec.Typeface = drFontType.Typeface?.Value;
    dmFontSpec.Panose = drFontType.Panose?.Value;
    dmFontSpec.Charset = ((byte?)drFontType.CharacterSet?.Value);
    dmFontSpec.Pitch = ((FontPitch?)drFontType.PitchFamily?.Value);
    return dmFontSpec;
  }

  private DM.FontSpec ReadFontSpec(DR.SupplementalFont drSupplementalFont)
  {
    var dmFontSpec = new DM.FontSpec();
    dmFontSpec.Script = drSupplementalFont.Script?.Value;
    dmFontSpec.Typeface = drSupplementalFont.Typeface?.Value;
    return dmFontSpec;
  }

}