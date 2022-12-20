using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocxToLatex.Converter.XLDocument.XLStyles;

/// <summary>
/// Repository containing information needed to work with styles, either paragraph or run type styles.
/// </summary>
public interface IXLStyleRepository
{
  /// <summary>
  /// Retrieves paragraph properties for given style.
  /// If the style doesn't override any properties, then the defaults are returned.
  /// </summary>
  /// <param name="styleValue">id of style, available in <see cref="ParagraphProperties"/></param>
  DocxDocument.Model.ParagraphProperties GetParagraphStyle(string styleValue);

  /// <summary>
  /// Retrieves run properties for given style.
  /// If the style doesn't override any properties, then the defaults are returned.
  /// </summary>
  /// <param name="styleValue">id of style, available in <see cref="DocumentFormat.OpenXml.Wordprocessing.RunProperties"/></param>
  DocxDocument.Model.RunProperties GetRunStyle(string styleValue);

  /// <summary>
  /// Returns style id for given style name. It's needed as some style names are not saved as-is.
  /// For example, a style with name "Nagłówek 1" can have style id "Nagwek1"
  /// </summary>
  string FindStyleId(string displayName);
}

public class XLStyleRepository : IXLStyleRepository
{
  private readonly IXLPropertiesFiller xlPropertiesFiller;
  private readonly Styles styles;

  private IDictionary<string, Style> stylesByValue;

  public XLStyleRepository(IXLPropertiesFiller xlPropertiesFiller, WordprocessingDocument document)
  {
    this.xlPropertiesFiller = xlPropertiesFiller;
    this.styles = document.MainDocumentPart.StyleDefinitionsPart.Styles;
  }

  public DocxDocument.Model.ParagraphProperties GetParagraphStyle(string styleValue)
  {
    var props = new DocxDocument.Model.ParagraphProperties();
    this.FillXLParagraphProperties(props, styleValue);

    return props;
  }

  public DocxDocument.Model.RunProperties GetRunStyle(string styleValue)
  {
    var props = new DocxDocument.Model.RunProperties();
    this.FillXLRunProperties(props, styleValue);

    return props;
  }

  public string FindStyleId(string displayName)
  {
    string strippedName = StripNonAlphaChars(displayName);
    foreach (Style style in this.styles.Where(e => e is Style))
    {
      if (style.StyleId == strippedName || style.StyleName?.Val == displayName)
      {
        return style.StyleId;
      }
    }

    return null;
  }

  private static string StripNonAlphaChars(string name)
  {
    StringBuilder sb = new StringBuilder(name);
    for (int idx = sb.Length - 1; idx >= 0; --idx)
    {
      if (sb[idx] > 'z' || char.IsLetterOrDigit(sb[idx]))
      {
        sb.Remove(idx, 1);
      }
    }

    return sb.ToString();
  }

  private void FillXLParagraphProperties(DocxDocument.Model.ParagraphProperties parProps, string styleValue)
  {
    Style style = this.GetStyle(styleValue);

    if (style.BasedOn != null)
    {
      this.FillXLParagraphProperties(parProps, style.BasedOn.Val);
    }

    if (style.StyleParagraphProperties != null)
    {
      this.xlPropertiesFiller.FillParagraphProperties(parProps, style.StyleParagraphProperties);
    }
  }

  private void FillXLRunProperties(DocxDocument.Model.RunProperties parProps, string styleValue)
  {
    Style style = this.GetStyle(styleValue);

    if (style.BasedOn != null)
    {
      this.FillXLRunProperties(parProps, style.BasedOn.Val);
    }

    if (style.StyleRunProperties != null)
    {
      this.xlPropertiesFiller.FillRunProperties(parProps, style.StyleRunProperties);
    }
  }

  private Style GetStyle(string styleValue)
  {
    if (this.stylesByValue == null)
    {
      this.stylesByValue = new Dictionary<string, Style>();
    }

    if (!this.stylesByValue.TryGetValue(styleValue, out Style style))
    {
      style = (Style)this.styles.ChildElements
        .Where(e => e is Style s)
        .SingleOrDefault(e => (e as Style).StyleId.Value == styleValue);

      this.stylesByValue[styleValue] = style;
    }

    return style;
  }
}