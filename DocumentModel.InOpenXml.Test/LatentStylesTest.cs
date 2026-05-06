namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Comprehensive test for DocumentModel.Styles.
/// </summary>
public class LatentStylesTest: _AbstractModelTestClass<Styles>
{

  /// <summary>
  /// Creates a sample Styles object with various property types.
  /// </summary>
  /// <returns>A populated Styles object.</returns>
  protected override Styles CreateSampleData()
  {
    var Styles = new Styles
    {
      LatentStyles = CreateSampleLatentStyles(),
    };
    return Styles;
  }

  /// <summary>
  /// Creates a collection of sample latent styles for use in document formatting.
  /// </summary>
  /// <remarks>This method initializes several latent styles with specific properties, such as primary
  /// status and UI priority, to facilitate consistent document styling.</remarks>
  /// <returns>A LatentStyles object containing predefined latent styles, including primary styles and annotations.</returns>
  internal static LatentStyles CreateSampleLatentStyles()
  {
    var latentStyles = new LatentStyles();
    latentStyles.Add(new LatentStyle()
    {
      Name = "Normal",
      PrimaryStyle = true
    });
    latentStyles.Add(new LatentStyle()
    {
      Name = "Heading 1",
      PrimaryStyle = true
    });
    latentStyles.Add(new LatentStyle()
    {
      Name = "Heading 6",
      SemiHidden = true,
      UnhideWhenUsed = true,
      PrimaryStyle = true
    });
    latentStyles.Add(new LatentStyle()
    {
      Name = "annotation text",
      UiPriority = 99,
    });
    latentStyles.Add(new LatentStyle()
    {
      Name = "Book title",
      UiPriority = 33,
      PrimaryStyle = true
    });

    return latentStyles;
  }

  /// <summary>
  /// Retrieves the collection of styles defined in the specified document.
  /// </summary>
  /// <param name="document">The document from which to obtain the styles collection.</param>
  /// <returns>A <see cref="Styles"/> object that contains all styles defined in the specified document.</returns>
  protected override Styles GetDataFromDocument(Document document)
  {
    return document.Styles;
  }

  /// <summary>
  /// Sets the specified styles data to the provided document and returns the updated styles.
  /// </summary>
  /// <param name="document">The document to which the styles data will be applied. Cannot be null.</param>
  /// <param name="data">The styles data to set on the document. Cannot be null.</param>
  /// <returns>The styles that have been set on the document.</returns>
  protected override Styles SetDataToDocument(Document document, Styles data)
  {
    document.Styles = data;
    return document.Styles;
  }

  /// <summary>
  /// Updates the specified document with the provided style data.
  /// </summary>
  /// <param name="document">The document to update with new style information.</param>
  /// <param name="data">The style data to apply to the document.</param>
  /// <returns>The updated style data after changes have been applied.</returns>
  protected override Styles UpdateDataInDocument(Document document, Styles data)
  {
    data.LatentStyles.Add(new LatentStyle()
    {
      Name = "Updated Style",
      PrimaryStyle = true
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