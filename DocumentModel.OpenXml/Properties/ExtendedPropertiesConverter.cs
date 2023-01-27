using DocumentFormat.OpenXml.ExtendedProperties;
using DocumentModel.Properties;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Application Specific File Properties.
/// </summary>
public static class ExtendedPropertiesConverter
{
  /// <summary>
  ///   Name of Document Template.
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
        openXmlElement?.AddChild(new Template { Text = value });
    }
  }

  /// <summary>
  ///   Name of Manager.
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
        openXmlElement?.AddChild(new Manager { Text = value });
    }
  }

  /// <summary>
  ///   Name of Company.
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
        openXmlElement?.AddChild(new Company { Text = value });
    }
  }

  /// <summary>
  ///   Total Number of Pages.
  /// </summary>
  public static Int32? GetPages(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Pages);
  }

  public static void SetPages(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Pages = Int32ValueConverter.CreateOpenXmlElement<Pages>(value);
  }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public static Int32? GetWords(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Words);
  }

  public static void SetWords(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Words = Int32ValueConverter.CreateOpenXmlElement<Words>(value);
  }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public static Int32? GetCharacters(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Characters);

  }

  public static void SetCharacters(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Characters = Int32ValueConverter.CreateOpenXmlElement<Characters>(value);
  }

  /// <summary>
  ///   Intended Format of Presentation.
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
        openXmlElement?.AddChild(new PresentationFormat { Text = value });
    }
  }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public static Int32? GetLines(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Lines);

  }

  public static void SetLines(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Lines = Int32ValueConverter.CreateOpenXmlElement<Lines>(value);
  }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public static Int32? GetParagraphs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Paragraphs);

  }

  public static void SetParagraphs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Paragraphs = Int32ValueConverter.CreateOpenXmlElement<Paragraphs>(value);
  }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public static Int32? GetSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Slides);

  }

  public static void SetSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Slides = Int32ValueConverter.CreateOpenXmlElement<Slides>(value);
  }

  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public static Int32? GetNotes(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Notes);

  }

  public static void SetNotes(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Notes = Int32ValueConverter.CreateOpenXmlElement<Notes>(value);
  }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public static Int32? GetTotalTime(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.TotalTime);

  }

  public static void SetTotalTime(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.TotalTime = Int32ValueConverter.CreateOpenXmlElement<TotalTime>(value);
  }

  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public static Int32? GetHiddenSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.HiddenSlides);
  }

  public static void SetHiddenSlides(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.HiddenSlides = Int32ValueConverter.CreateOpenXmlElement<HiddenSlides>(value);
  }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public static Int32? GetMultimediaClips(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.MultimediaClips);

  }

  public static void SetMultimediaClips(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.MultimediaClips = Int32ValueConverter.CreateOpenXmlElement<MultimediaClips>(value);
  }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public static Boolean? GetScaleCrop(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.ScaleCrop);
  }

  public static void SetScaleCrop(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.ScaleCrop = BooleanValueConverter.CreateOpenXmlElement<ScaleCrop>(value);
  }

  /// <summary>
  ///   Heading Pairs.
  /// </summary>
  public static VectorVariant? GetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return HeadingPairsConverter.CreateModelElement(openXmlElement?.HeadingPairs);
  }

  public static void SetHeadingPairs(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeadingPairs = HeadingPairsConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  ///   Part Titles.
  /// </summary>
  public static VectorVariant? GetTitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return TitlesOfPartsConverter.GetVTVector(openXmlElement?.TitlesOfParts);
  }

  public static void SetTitlesOfParts(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      TitlesOfPartsConverter.SetVTVector(openXmlElement.TitlesOfParts, value);
  }

  /// <summary>
  ///   Links Up-to-Date.
  /// </summary>
  public static Boolean? GetLinksUpToDate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LinksUpToDate);
  }

  public static void SetLinksUpToDate(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.LinksUpToDate = BooleanValueConverter.CreateOpenXmlElement<LinksUpToDate>(value);
  }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public static Int32? GetCharactersWithSpaces(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.CharactersWithSpaces);

  }

  public static void SetCharactersWithSpaces(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.CharactersWithSpaces = Int32ValueConverter.CreateOpenXmlElement<CharactersWithSpaces>(value);
  }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public static Boolean? GetSharedDocument(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.SharedDocument);
  }

  public static void SetSharedDocument(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.SharedDocument = BooleanValueConverter.CreateOpenXmlElement<SharedDocument>(value);

  }

  /// <summary>
  ///   Relative Hyperlink Base.
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
        openXmlElement?.AddChild(new HyperlinkBase { Text = value });
    }
  }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public static VectorVariant? GetHyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    return HyperlinkListConverter.GetVTVector(openXmlElement?.HyperlinkList);
  }

  public static void SetHyperlinkList(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, VectorVariant? value)
  {
    if (openXmlElement != null)
      HyperlinkListConverter.SetVTVector(openXmlElement.HyperlinkList, value);
  }

  /// <summary>
  ///   Hyperlinks Changed.
  /// </summary>
  public static Boolean? GetHyperlinksChanged(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LinksUpToDate);
  }

  public static void SetHyperlinksChanged(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.HyperlinksChanged = BooleanValueConverter.CreateOpenXmlElement<HyperlinksChanged>(value);

  }

  /// <summary>
  ///   Digital Signature.
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
  ///   Application Name.
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
        openXmlElement?.AddChild(new Application { Text = value });
    }
  }

  /// <summary>
  ///   Application Version.
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
        openXmlElement?.AddChild(new ApplicationVersion { Text = value });
    }
  }

  /// <summary>
  ///   Document Security.
  /// </summary>
  public static Int32? GetDocumentSecurity(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.DocumentSecurity);
  }

  public static void SetDocumentSecurity(DocumentFormat.OpenXml.ExtendedProperties.Properties openXmlElement, Int32? value)
  {
    openXmlElement.DocumentSecurity = Int32ValueConverter.CreateOpenXmlElement<DocumentSecurity>(value);
  }

  public static ExtendedProperties? CreateModelElement(DocumentFormat.OpenXml.ExtendedProperties.Properties? openXmlElement)
  {
    var value = new ExtendedProperties();
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

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(ExtendedProperties value)
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