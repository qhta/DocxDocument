namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Application Specific File Properties.
/// </summary>
public static class ExtendedPropertiesConverter
{
  /// <summary>
  /// Name of Document Template.
  /// </summary>
  public static String? GetTemplate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Template?.Text;
  }
  public static void SetTemplate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Template != null)
    {
      if (value != null)
        openXmlElement.Template.Text = value;
      else
        openXmlElement.Template = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Template() {Text = value});
    }
  }
  
  /// <summary>
  /// Name of Manager.
  /// </summary>
  public static String? GetManager(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Manager?.Text;
  }
  public static void SetManager(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Manager != null)
    {
      if (value != null)
        openXmlElement.Manager.Text = value;
      else
        openXmlElement.Manager = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Manager() {Text = value});
    }
  }
  
  /// <summary>
  /// Name of Company.
  /// </summary>
  public static String? GetCompany(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Company?.Text;
  }
  public static void SetCompany(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Company != null)
    {
      if (value != null)
        openXmlElement.Company.Text = value;
      else
        openXmlElement.Company = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Company() {Text = value});
    }
  }
  
  /// <summary>
  /// Total Number of Pages.
  /// </summary>
  public static String? GetPages(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Pages?.Text;
  }
  public static void SetPages(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Pages != null)
    {
      if (value != null)
        openXmlElement.Pages.Text = value;
      else
        openXmlElement.Pages = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Pages() {Text = value});
    }
  }
  
  /// <summary>
  /// Word Count.
  /// </summary>
  public static String? GetWords(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Words?.Text;
  }
  public static void SetWords(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Words != null)
    {
      if (value != null)
        openXmlElement.Words.Text = value;
      else
        openXmlElement.Words = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Words() {Text = value});
    }
  }
  
  /// <summary>
  /// Total Number of Characters.
  /// </summary>
  public static String? GetCharacters(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Characters?.Text;
  }
  public static void SetCharacters(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Characters != null)
    {
      if (value != null)
        openXmlElement.Characters.Text = value;
      else
        openXmlElement.Characters = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Characters() {Text = value});
    }
  }
  
  /// <summary>
  /// Intended Format of Presentation.
  /// </summary>
  public static String? GetPresentationFormat(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.PresentationFormat?.Text;
  }
  public static void SetPresentationFormat(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.PresentationFormat != null)
    {
      if (value != null)
        openXmlElement.PresentationFormat.Text = value;
      else
        openXmlElement.PresentationFormat = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.PresentationFormat() {Text = value});
    }
  }
  
  /// <summary>
  /// Number of Lines.
  /// </summary>
  public static String? GetLines(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Lines?.Text;
  }
  public static void SetLines(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Lines != null)
    {
      if (value != null)
        openXmlElement.Lines.Text = value;
      else
        openXmlElement.Lines = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Lines() {Text = value});
    }
  }
  
  /// <summary>
  /// Total Number of Paragraphs.
  /// </summary>
  public static String? GetParagraphs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Paragraphs?.Text;
  }
  public static void SetParagraphs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Paragraphs != null)
    {
      if (value != null)
        openXmlElement.Paragraphs.Text = value;
      else
        openXmlElement.Paragraphs = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Paragraphs() {Text = value});
    }
  }
  
  /// <summary>
  /// Slides Metadata Element.
  /// </summary>
  public static String? GetSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Slides?.Text;
  }
  public static void SetSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Slides != null)
    {
      if (value != null)
        openXmlElement.Slides.Text = value;
      else
        openXmlElement.Slides = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Slides() {Text = value});
    }
  }
  
  /// <summary>
  /// Number of Slides Containing Notes.
  /// </summary>
  public static String? GetNotes(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Notes?.Text;
  }
  public static void SetNotes(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Notes != null)
    {
      if (value != null)
        openXmlElement.Notes.Text = value;
      else
        openXmlElement.Notes = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Notes() {Text = value});
    }
  }
  
  /// <summary>
  /// Total Edit Time Metadata Element.
  /// </summary>
  public static String? GetTotalTime(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.TotalTime?.Text;
  }
  public static void SetTotalTime(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.TotalTime != null)
    {
      if (value != null)
        openXmlElement.TotalTime.Text = value;
      else
        openXmlElement.TotalTime = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.TotalTime() {Text = value});
    }
  }
  
  /// <summary>
  /// Number of Hidden Slides.
  /// </summary>
  public static String? GetHiddenSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.HiddenSlides?.Text;
  }
  public static void SetHiddenSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.HiddenSlides != null)
    {
      if (value != null)
        openXmlElement.HiddenSlides.Text = value;
      else
        openXmlElement.HiddenSlides = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.HiddenSlides() {Text = value});
    }
  }
  
  /// <summary>
  /// Total Number of Multimedia Clips.
  /// </summary>
  public static String? GetMultimediaClips(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.MultimediaClips?.Text;
  }
  public static void SetMultimediaClips(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.MultimediaClips != null)
    {
      if (value != null)
        openXmlElement.MultimediaClips.Text = value;
      else
        openXmlElement.MultimediaClips = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.MultimediaClips() {Text = value});
    }
  }
  
  /// <summary>
  /// Thumbnail Display Mode.
  /// </summary>
  public static String? GetScaleCrop(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.ScaleCrop?.Text;
  }
  public static void SetScaleCrop(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.ScaleCrop != null)
    {
      if (value != null)
        openXmlElement.ScaleCrop.Text = value;
      else
        openXmlElement.ScaleCrop = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.ScaleCrop() {Text = value});
    }
  }
  
  /// <summary>
  /// Heading Pairs.
  /// </summary>
  public static DocumentModel.Properties.HeadingPairs? GetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return HeadingPairsConverter.CreateModelElement(openXmlElement?.HeadingPairs);
  }
  public static void SetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, DocumentModel.Properties.HeadingPairs? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeadingPairs = HeadingPairsConverter.CreateOpenXmlElement(value);
  }
  
  /// <summary>
  /// Part Titles.
  /// </summary>
  public static DocumentModel.StringList? GetTitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return TitlesOfPartsConverter.CreateModelElement(openXmlElement?.TitlesOfParts);
  }
  public static void SetTitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, DocumentModel.StringList? value)
  {
    if (openXmlElement != null)
      openXmlElement.TitlesOfParts = TitlesOfPartsConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  /// Links Up-to-Date.
  /// </summary>
  public static String? GetLinksUpToDate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.LinksUpToDate?.Text;
  }
  public static void SetLinksUpToDate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.LinksUpToDate != null)
    {
      if (value != null)
        openXmlElement.LinksUpToDate.Text = value;
      else
        openXmlElement.LinksUpToDate = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.LinksUpToDate() {Text = value});
    }
  }
  
  /// <summary>
  /// Number of Characters (With Spaces).
  /// </summary>
  public static String? GetCharactersWithSpaces(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.CharactersWithSpaces?.Text;
  }
  public static void SetCharactersWithSpaces(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.CharactersWithSpaces != null)
    {
      if (value != null)
        openXmlElement.CharactersWithSpaces.Text = value;
      else
        openXmlElement.CharactersWithSpaces = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.CharactersWithSpaces() {Text = value});
    }
  }
  
  /// <summary>
  /// Shared Document.
  /// </summary>
  public static String? GetSharedDocument(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.SharedDocument?.Text;
  }
  public static void SetSharedDocument(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.SharedDocument != null)
    {
      if (value != null)
        openXmlElement.SharedDocument.Text = value;
      else
        openXmlElement.SharedDocument = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.SharedDocument() {Text = value});
    }
  }
  
  /// <summary>
  /// Relative Hyperlink Base.
  /// </summary>
  public static String? GetHyperlinkBase(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.HyperlinkBase?.Text;
  }
  public static void SetHyperlinkBase(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.HyperlinkBase != null)
    {
      if (value != null)
        openXmlElement.HyperlinkBase.Text = value;
      else
        openXmlElement.HyperlinkBase = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.HyperlinkBase() {Text = value});
    }
  }
  
  /// <summary>
  /// Hyperlink List.
  /// </summary>
  public static DocumentModel.StringList? GetHyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    return HyperlinkListConverter.CreateModelElement(openXmlElement?.HyperlinkList);
  }
  public static void SetHyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, DocumentModel.StringList? value)
  {
    if (openXmlElement != null)
      openXmlElement.HyperlinkList = HyperlinkListConverter.CreateOpenXmlElement(value);
  }
  
  /// <summary>
  /// Hyperlinks Changed.
  /// </summary>
  public static String? GetHyperlinksChanged(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    return openXmlElement?.HyperlinksChanged?.Text;
  }
  public static void SetHyperlinksChanged(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.HyperlinksChanged != null)
    {
      if (value != null)
        openXmlElement.HyperlinksChanged.Text = value;
      else
        openXmlElement.HyperlinksChanged = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.HyperlinksChanged() {Text = value});
    }
  }
  
  /// <summary>
  /// Digital Signature.
  /// </summary>
  public static DocumentModel.Properties.DigitalSignature? GetDigitalSignature(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return DigitalSignatureConverter.CreateModelElement(openXmlElement?.DigitalSignature);
  }
  public static void SetDigitalSignature(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, DocumentModel.Properties.DigitalSignature? value)
  {
    if (openXmlElement != null)
      openXmlElement.DigitalSignature = DigitalSignatureConverter.CreateOpenXmlElement(value);
  }
  
  /// <summary>
  /// Application Name.
  /// </summary>
  public static String? GetApplication(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.Application?.Text;
  }
  public static void SetApplication(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.Application != null)
    {
      if (value != null)
        openXmlElement.Application.Text = value;
      else
        openXmlElement.Application = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.Application() {Text = value});
    }
  }
  
  /// <summary>
  /// Application Version.
  /// </summary>
  public static String? GetApplicationVersion(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.ApplicationVersion?.Text;
  }
  public static void SetApplicationVersion(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.ApplicationVersion != null)
    {
      if (value != null)
        openXmlElement.ApplicationVersion.Text = value;
      else
        openXmlElement.ApplicationVersion = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.ApplicationVersion() {Text = value});
    }
  }
  
  /// <summary>
  /// Document Security.
  /// </summary>
  public static String? GetDocumentSecurity(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return openXmlElement?.DocumentSecurity?.Text;
  }
  public static void SetDocumentSecurity(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, String? value)
  {
    if (openXmlElement?.DocumentSecurity != null)
    {
      if (value != null)
        openXmlElement.DocumentSecurity.Text = value;
      else
        openXmlElement.DocumentSecurity = null;
    }
    else
    {
      if (value != null)
        openXmlElement?.AddChild(new DocumentFormat.OpenXml.ExtendedProperties.DocumentSecurity() {Text = value});
    }
  }
  
  public static DocumentModel.Properties.ExtendedProperties? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    var value = new DocumentModel.Properties.ExtendedProperties();
    if (openXmlElement != null)
    {
      value.Template = GetTemplate(openXmlElement);
      value.Manager = GetManager(openXmlElement);
      value.Company = GetCompany(openXmlElement);
      value.Pages = GetPages(openXmlElement);
      value.Words = GetWords(openXmlElement);
      value.Characters = GetCharacters(openXmlElement);
      value.PresentationFormat = GetPresentationFormat(openXmlElement);
      value.Lines = GetLines(openXmlElement);
      value.Paragraphs = GetParagraphs(openXmlElement);
      value.Slides = GetSlides(openXmlElement);
      value.Notes = GetNotes(openXmlElement);
      value.TotalTime = GetTotalTime(openXmlElement);
      value.HiddenSlides = GetHiddenSlides(openXmlElement);
      value.MultimediaClips = GetMultimediaClips(openXmlElement);
      value.ScaleCrop = GetScaleCrop(openXmlElement);
      value.HeadingPairs = GetHeadingPairs(openXmlElement);
      value.TitlesOfParts = GetTitlesOfParts(openXmlElement);
      value.LinksUpToDate = GetLinksUpToDate(openXmlElement);
      value.CharactersWithSpaces = GetCharactersWithSpaces(openXmlElement);
      value.SharedDocument = GetSharedDocument(openXmlElement);
      value.HyperlinkBase = GetHyperlinkBase(openXmlElement);
      value.HyperlinkList = GetHyperlinkList(openXmlElement);
      value.HyperlinksChanged = GetHyperlinksChanged(openXmlElement);
      value.DigitalSignature = GetDigitalSignature(openXmlElement);
      value.Application = GetApplication(openXmlElement);
      value.ApplicationVersion = GetApplicationVersion(openXmlElement);
      value.DocumentSecurity = GetDocumentSecurity(openXmlElement);
    }
    return value;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DocumentModel.Properties.ExtendedProperties value)
    where OpenXmlElementType : DocumentFormat.OpenXml.ExtendedProperties.Properties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    {
      SetTemplate(openXmlElement, value.Template);
      SetManager(openXmlElement, value.Manager);
      SetCompany(openXmlElement, value.Company);
      SetPages(openXmlElement, value.Pages);
      SetWords(openXmlElement, value.Words);
      SetCharacters(openXmlElement, value.Characters);
      SetPresentationFormat(openXmlElement, value.PresentationFormat);
      SetLines(openXmlElement, value.Lines);
      SetParagraphs(openXmlElement, value.Paragraphs);
      SetSlides(openXmlElement, value.Slides);
      SetNotes(openXmlElement, value.Notes);
      SetTotalTime(openXmlElement, value.TotalTime);
      SetHiddenSlides(openXmlElement, value.HiddenSlides);
      SetMultimediaClips(openXmlElement, value.MultimediaClips);
      SetScaleCrop(openXmlElement, value.ScaleCrop);
      SetHeadingPairs(openXmlElement, value.HeadingPairs);
      SetTitlesOfParts(openXmlElement, value.TitlesOfParts);
      SetLinksUpToDate(openXmlElement, value.LinksUpToDate);
      SetCharactersWithSpaces(openXmlElement, value.CharactersWithSpaces);
      SetSharedDocument(openXmlElement, value.SharedDocument);
      SetHyperlinkBase(openXmlElement, value.HyperlinkBase);
      SetHyperlinkList(openXmlElement, value.HyperlinkList);
      SetHyperlinksChanged(openXmlElement, value.HyperlinksChanged);
      SetDigitalSignature(openXmlElement, value.DigitalSignature);
      SetApplication(openXmlElement, value.Application);
      SetApplicationVersion(openXmlElement, value.ApplicationVersion);
      SetDocumentSecurity(openXmlElement, value.DocumentSecurity);
    }
    return openXmlElement;
  }
}
