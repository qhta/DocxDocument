namespace DocumentModel.InOpenXml.Test;

/// <summary>
/// Provides comprehensive serialization tests for <see cref="DocumentModel.ContentProperties"/>.
/// </summary>
public class ContentPropertiesTest : _AbstractModelTestClass<ContentProperties>
{

  /// <summary>
  /// Creates a sample <see cref="ContentProperties"/> instance for testing.
  /// </summary>
  /// <returns>A populated <see cref="ContentProperties"/> object.</returns>
  protected override ContentProperties CreateSampleData()
  {
    var props = new ContentProperties
    {
      Template = "Normal.dotm",
      Application = "Microsoft Word",
      ApplicationVersion = "16.0000",
      Company = "Test Company",
      Manager = "Test Manager",
      SharedDocument = false,
      LinksUpToDate = false,
      HyperlinksChanged = false,
      PresentationFormat = "Print",
      ScaleCrop = true,


      DocumentSecurity = DocumentSecurity.ReadOnly | DocumentSecurity.PasswordProtected,
      DigitalSignature = new HexBinary([0x01, 0x02, 0x03, 0x04, 0x05]),
      HyperlinkBase = "http://www.example.com/",
      HeadingPairs = new HeadingPairs
      {
        new HeadingPair { Name = "Heading 1", Number = 1 },
        new HeadingPair { Name = "Heading 2", Number = 2 },
        new HeadingPair { Name = "Heading 3", Number = 3 }
      },

      TitlesOfParts = new StringList
      {
        "Introduction",
        "Chapter 1",
        "Chapter 2"
      },

      HyperlinkList = new HyperlinkList([
        new HyperlinkInfo
        {
          Action = HyperlinkAction.Change, Attachment = HyperlinkAttachment.Field,
          Location = "http://www.example.com/link1"
        },
        new HyperlinkInfo
        {
          Action = HyperlinkAction.Remove, Attachment = HyperlinkAttachment.Background,
          Location = "http://www.example.com/link2"
        },
      ]),
    };
    return props;
  }

  /// <summary>
  /// Retrieves the content properties from the specified document.
  /// </summary>
  /// <param name="document">The document from which to obtain the content properties. Cannot be null.</param>
  /// <returns>The content properties associated with the specified document.</returns>
  protected override ContentProperties GetDataFromDocument(Document document)
  {
    return document.ContentProperties;
  }

  /// <summary>
  /// Sets the specified content properties on the provided document and returns the updated content properties.
  /// </summary>
  /// <param name="document">The document to which the content properties will be applied.</param>
  /// <param name="data">The content properties to set on the document.</param>
  /// <returns>The updated content properties of the document after assignment.</returns>
  protected override ContentProperties SetDataToDocument(Document document, ContentProperties data)
  {
    document.ContentProperties = data;
    return document.ContentProperties;
  }

  /// <summary>
  /// Updates the specified document with the provided content properties.
  /// </summary>
  /// <param name="document">The document to update with new content properties.</param>
  /// <param name="data">The content properties to apply to the document.</param>
  /// <returns>The updated content properties after applying changes to the document.</returns>
  protected override ContentProperties UpdateDataInDocument(Document document, ContentProperties data)
  {
    TestHelper.ChangeTestData(data);
    return data;
  }

  /// <summary>
  /// Retrieves the XML markup representing the extended file properties from the specified Wordprocessing document.
  /// </summary>
  /// <param name="document">The document from which to extract the extended file properties as XML. Must not be null and must contain a valid
  /// WordprocessingDocument with an ExtendedFilePropertiesPart.</param>
  /// <returns>A string containing the XML markup of the extended file properties for the specified document.</returns>
  protected override string GetOpenXmlFromDocument(Document document)
  {
    return document.WordprocessingDocument!.ExtendedFilePropertiesPart!.Properties!.OuterXml;
  }
}