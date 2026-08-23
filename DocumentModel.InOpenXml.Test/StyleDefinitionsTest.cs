namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Styles.
/// </summary>
public class StyleDefinitionsTest : _AbstractModelTestClass<Styles>
{
  /// <summary>
  /// Creates and returns a sample set of styles for demonstration or testing purposes.
  /// </summary>
  /// <returns>A <see cref="Styles"/> object containing sample style data.</returns>
  protected override Styles CreateSampleData()
  {
    return CreateSampleStyles();
  }

  /// <summary>
  /// Creates a sample Styles object with various property types.
  /// </summary>
  /// <returns>A populated Styles object.</returns>
  internal static Styles CreateSampleStyles()
  {
    var Styles = new Styles();
    Styles.StyleDefinitions.Add(new Style()
    {
      StyleName = "Normal",
      Type = StyleType.Paragraph,
      IsDefault = true,
      IsPrimary = true,
      UIPriority = 1,
    });
    Styles.StyleDefinitions.Add(new Style()
    {
      StyleName = "Heading 1",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 9,
    });
    Styles.StyleDefinitions.Add(new Style()
    {
      StyleName = "Heading 6",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 14,
    });
    Styles.StyleDefinitions.Add(new Style()
    {
      StyleName = "annotation text",
      Type = StyleType.Character,
      IsCustom = true,
      BasedOn = "DefaultParagraphFont",
      UIPriority = 99,
    });
    Styles.StyleDefinitions.Add(new Style()
    {
      StyleName = "Book title",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 22,
      IsHidden = StyleHide.Hidden | StyleHide.UnhiddenWhenUsed,
    });

    return Styles;
  }

  /// <summary>
  /// Updates the specified document with the provided style data.
  /// </summary>
  /// <param name="document">The document to update with new style information.</param>
  /// <param name="data">The style data to apply to the document.</param>
  /// <returns>The updated style data after changes have been applied.</returns>
  protected override Styles UpdateDataInDocument(Document document, Styles data)
  {
    data.StyleDefinitions.Add(new Style()
    {
      StyleName = "NewStyle",
      Type = StyleType.Paragraph,
      IsCustom = true,
      BasedOn = "Normal",
      NextParagraphStyle = "Normal",
      UIPriority = 50,
    });
    return data;
  }

  /// <summary>
  /// Retrieves the raw Open XML markup for the style definitions part of the specified WordprocessingML document.
  /// </summary>
  /// <remarks>This method assumes that the document contains a main document part and a style definitions part.
  /// If these parts are missing, a NullReferenceException may occur.</remarks>
  /// <param name="document">The document from which to extract the style definitions as Open XML. Must not be null and must contain a valid
  /// style definitions part.</param>
  /// <returns>A string containing the outer XML of the style definitions part of the document.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.MainDocumentPart!.StyleDefinitionsPart!.Styles!.OuterXml;
  }


}