using DocumentModel;

namespace DocumentModel.OpenXml.Properties;

/// <summary>
///   Application Specific File Properties.
/// </summary>
public static class ExtendedPropertiesConverter
{
  /// <summary>
  ///   Name of Document Template.
  /// </summary>
  public static String? GetTemplate(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.Template?.Text;
  }

  public static void SetTemplate(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.Template { Text = value });
    }
  }

  /// <summary>
  ///   Name of Manager.
  /// </summary>
  public static String? GetManager(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.Manager?.Text;
  }

  public static void SetManager(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.Manager { Text = value });
    }
  }

  /// <summary>
  ///   Name of Company.
  /// </summary>
  public static String? GetCompany(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.Company?.Text;
  }

  public static void SetCompany(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.Company { Text = value });
    }
  }

  /// <summary>
  ///   Total Number of Pages.
  /// </summary>
  public static Int32? GetPages(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Pages);
  }

  public static void SetPages(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Pages = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Pages>(value);
  }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public static Int32? GetWords(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Words);
  }

  public static void SetWords(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Words = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Words>(value);
  }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public static Int32? GetCharacters(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Characters);

  }

  public static void SetCharacters(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Characters = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Characters>(value);
  }

  /// <summary>
  ///   Intended Format of Presentation.
  /// </summary>
  public static String? GetPresentationFormat(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.PresentationFormat?.Text;
  }

  public static void SetPresentationFormat(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.PresentationFormat { Text = value });
    }
  }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public static Int32? GetLines(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Lines);

  }

  public static void SetLines(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Lines = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Lines>(value);
  }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public static Int32? GetParagraphs(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Paragraphs);

  }

  public static void SetParagraphs(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Paragraphs = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Paragraphs>(value);
  }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public static Int32? GetSlides(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Slides);

  }

  public static void SetSlides(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Slides = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Slides>(value);
  }

  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public static Int32? GetNotes(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Notes);

  }

  public static void SetNotes(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Notes = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.Notes>(value);
  }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public static Int32? GetTotalTime(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.TotalTime);

  }

  public static void SetTotalTime(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.TotalTime = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.TotalTime>(value);
  }

  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public static Int32? GetHiddenSlides(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.HiddenSlides);
  }

  public static void SetHiddenSlides(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.HiddenSlides = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.HiddenSlides>(value);
  }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public static Int32? GetMultimediaClips(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.MultimediaClips);

  }

  public static void SetMultimediaClips(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.MultimediaClips = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.MultimediaClips>(value);
  }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public static Boolean? GetScaleCrop(DXExtProps.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.ScaleCrop);
  }

  public static void SetScaleCrop(DXExtProps.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.ScaleCrop = BooleanValueConverter.CreateOpenXmlElement<DXExtProps.ScaleCrop>(value);
  }

  /// <summary>
  ///   Heading Pairs.
  /// </summary>
  public static DMProps.HeadingPairs? GetHeadingPairs(DXExtProps.Properties openXmlElement)
  {
    return HeadingPairsConverter.CreateModelElement(openXmlElement?.HeadingPairs);
  }

  public static void SetHeadingPairs(DXExtProps.Properties openXmlElement, DMProps.HeadingPairs? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeadingPairs = HeadingPairsConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  ///   Part Titles.
  /// </summary>
  public static StringList? GetTitlesOfParts(DXExtProps.Properties openXmlElement)
  {
    return TitlesOfPartsConverter.GetStrings(openXmlElement?.TitlesOfParts);
  }

  public static void SetTitlesOfParts(DXExtProps.Properties openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      TitlesOfPartsConverter.SetStrings(openXmlElement.TitlesOfParts, value);
  }

  /// <summary>
  ///   Links Up-to-Date.
  /// </summary>
  public static Boolean? GetLinksUpToDate(DXExtProps.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LinksUpToDate);
  }

  public static void SetLinksUpToDate(DXExtProps.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.LinksUpToDate = BooleanValueConverter.CreateOpenXmlElement<DXExtProps.LinksUpToDate>(value);
  }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public static Int32? GetCharactersWithSpaces(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.CharactersWithSpaces);

  }

  public static void SetCharactersWithSpaces(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.CharactersWithSpaces = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.CharactersWithSpaces>(value);
  }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public static Boolean? GetSharedDocument(DXExtProps.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.SharedDocument);
  }

  public static void SetSharedDocument(DXExtProps.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.SharedDocument = BooleanValueConverter.CreateOpenXmlElement<DXExtProps.SharedDocument>(value);

  }

  /// <summary>
  ///   Relative Hyperlink Base.
  /// </summary>
  public static String? GetHyperlinkBase(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.HyperlinkBase?.Text;
  }

  public static void SetHyperlinkBase(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.HyperlinkBase { Text = value });
    }
  }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public static StringList? GetHyperlinkList(DXExtProps.Properties? openXmlElement)
  {
    return HyperlinkListConverter.GetStrings(openXmlElement?.HyperlinkList);
  }

  public static void SetHyperlinkList(DXExtProps.Properties openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      HyperlinkListConverter.SetStrings(openXmlElement.HyperlinkList, value);
  }

  /// <summary>
  ///   Hyperlinks Changed.
  /// </summary>
  public static Boolean? GetHyperlinksChanged(DXExtProps.Properties? openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LinksUpToDate);
  }

  public static void SetHyperlinksChanged(DXExtProps.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.HyperlinksChanged = BooleanValueConverter.CreateOpenXmlElement<DXExtProps.HyperlinksChanged>(value);

  }

  /// <summary>
  ///   Digital Signature.
  /// </summary>
  public static byte[]? GetDigitalSignature(DXExtProps.Properties openXmlElement)
  {
    return DigitalSignatureConverter.CreateModelElement(openXmlElement?.DigitalSignature);
  }

  public static void SetDigitalSignature(DXExtProps.Properties openXmlElement, byte[]? value)
  {
    if (openXmlElement != null)
      openXmlElement.DigitalSignature = DigitalSignatureConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  ///   Application Name.
  /// </summary>
  public static String? GetApplication(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.Application?.Text;
  }

  public static void SetApplication(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.Application { Text = value });
    }
  }

  /// <summary>
  ///   Application Version.
  /// </summary>
  public static String? GetApplicationVersion(DXExtProps.Properties openXmlElement)
  {
    return openXmlElement?.ApplicationVersion?.Text;
  }

  public static void SetApplicationVersion(DXExtProps.Properties openXmlElement, String? value)
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
        openXmlElement?.AddChild(new DXExtProps.ApplicationVersion { Text = value });
    }
  }

  /// <summary>
  ///   Document Security.
  /// </summary>
  public static Int32? GetDocumentSecurity(DXExtProps.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.DocumentSecurity);
  }

  public static void SetDocumentSecurity(DXExtProps.Properties openXmlElement, Int32? value)
  {
    openXmlElement.DocumentSecurity = Int32ValueConverter.CreateOpenXmlElement<DXExtProps.DocumentSecurity>(value);
  }

  public static ContentProperties? GetContentProperties(DXExtProps.Properties? openXmlElement)
  {
    var value = new ContentProperties();
    if (openXmlElement != null)
    {
      value.Template = GetTemplate(openXmlElement);
      value.Manager = GetManager(openXmlElement);
      value.Company = GetCompany(openXmlElement);
      value.PresentationFormat = GetPresentationFormat(openXmlElement);
      value.ScaleCrop = GetScaleCrop(openXmlElement);
      value.HeadingPairs = GetHeadingPairs(openXmlElement);
      value.TitlesOfParts = GetTitlesOfParts(openXmlElement);
      value.LinksUpToDate = GetLinksUpToDate(openXmlElement);
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

  public static StatisticProperties? GetStatisticProperties(DXExtProps.Properties? openXmlElement)
  {
    var value = new StatisticProperties();
    if (openXmlElement != null)
    {
      value.Pages = GetPages(openXmlElement);
      value.Words = GetWords(openXmlElement);
      value.Characters = GetCharacters(openXmlElement);
      value.CharactersWithSpaces = GetCharactersWithSpaces(openXmlElement);
      value.Lines = GetLines(openXmlElement);
      value.Paragraphs = GetParagraphs(openXmlElement);
      value.Slides = GetSlides(openXmlElement);
      value.Notes = GetNotes(openXmlElement);
      value.HiddenSlides = GetHiddenSlides(openXmlElement);
      value.MultimediaClips = GetMultimediaClips(openXmlElement);
      value.TotalTime = GetTotalTime(openXmlElement);
    }
    return value;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(ContentProperties? value1, StatisticProperties? value2)
    where OpenXmlElementType : DXExtProps.Properties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    {
      if (value1 != null)
      {
        SetTemplate(openXmlElement, value1.Template);
        SetManager(openXmlElement, value1.Manager);
        SetCompany(openXmlElement, value1.Company);
        SetPresentationFormat(openXmlElement, value1.PresentationFormat);
        SetScaleCrop(openXmlElement, value1.ScaleCrop);
        SetHeadingPairs(openXmlElement, value1.HeadingPairs);
        SetTitlesOfParts(openXmlElement, value1.TitlesOfParts);
        SetLinksUpToDate(openXmlElement, value1.LinksUpToDate);
        SetSharedDocument(openXmlElement, value1.SharedDocument);
        SetHyperlinkBase(openXmlElement, value1.HyperlinkBase);
        SetHyperlinkList(openXmlElement, value1.HyperlinkList);
        SetHyperlinksChanged(openXmlElement, value1.HyperlinksChanged);
        SetDigitalSignature(openXmlElement, value1.DigitalSignature);
        SetApplication(openXmlElement, value1.Application);
        SetApplicationVersion(openXmlElement, value1.ApplicationVersion);
        SetDocumentSecurity(openXmlElement, value1.DocumentSecurity);
      }
      if (value2 != null)
      {
        SetPages(openXmlElement, value2.Pages);
        SetWords(openXmlElement, value2.Words);
        SetCharacters(openXmlElement, value2.Characters);
        SetCharactersWithSpaces(openXmlElement, value2.CharactersWithSpaces);
        SetLines(openXmlElement, value2.Lines);
        SetParagraphs(openXmlElement, value2.Paragraphs);
        SetSlides(openXmlElement, value2.Slides);
        SetNotes(openXmlElement, value2.Notes);
        SetTotalTime(openXmlElement, value2.TotalTime);
        SetHiddenSlides(openXmlElement, value2.HiddenSlides);
        SetMultimediaClips(openXmlElement, value2.MultimediaClips);
      }
    }
    return openXmlElement;
  }
}