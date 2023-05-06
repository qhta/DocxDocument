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
  public static String? GetTemplate(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.Template?.Text;
  }

  public static void SetTemplate(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.Template { Text = value });
    }
  }

  /// <summary>
  ///   Name of Manager.
  /// </summary>
  public static String? GetManager(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.Manager?.Text;
  }

  public static void SetManager(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.Manager { Text = value });
    }
  }

  /// <summary>
  ///   Name of Company.
  /// </summary>
  public static String? GetCompany(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.Company?.Text;
  }

  public static void SetCompany(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.Company { Text = value });
    }
  }

  /// <summary>
  ///   Total Number of Pages.
  /// </summary>
  public static Int32? GetPages(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Pages);
  }

  public static void SetPages(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Pages = Int32ValueConverter.CreateOpenXmlElement<DXEP.Pages>(value);
  }

  /// <summary>
  ///   Word Count.
  /// </summary>
  public static Int32? GetWords(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Words);
  }

  public static void SetWords(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Words = Int32ValueConverter.CreateOpenXmlElement<DXEP.Words>(value);
  }

  /// <summary>
  ///   Total Number of Characters.
  /// </summary>
  public static Int32? GetCharacters(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Characters);

  }

  public static void SetCharacters(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Characters = Int32ValueConverter.CreateOpenXmlElement<DXEP.Characters>(value);
  }

  /// <summary>
  ///   Intended Format of Presentation.
  /// </summary>
  public static String? GetPresentationFormat(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.PresentationFormat?.Text;
  }

  public static void SetPresentationFormat(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.PresentationFormat { Text = value });
    }
  }

  /// <summary>
  ///   Number of Lines.
  /// </summary>
  public static Int32? GetLines(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Lines);

  }

  public static void SetLines(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Lines = Int32ValueConverter.CreateOpenXmlElement<DXEP.Lines>(value);
  }

  /// <summary>
  ///   Total Number of Paragraphs.
  /// </summary>
  public static Int32? GetParagraphs(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Paragraphs);

  }

  public static void SetParagraphs(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Paragraphs = Int32ValueConverter.CreateOpenXmlElement<DXEP.Paragraphs>(value);
  }

  /// <summary>
  ///   Slides Metadata Element.
  /// </summary>
  public static Int32? GetSlides(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Slides);

  }

  public static void SetSlides(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Slides = Int32ValueConverter.CreateOpenXmlElement<DXEP.Slides>(value);
  }

  /// <summary>
  ///   Number of Slides Containing Notes.
  /// </summary>
  public static Int32? GetNotes(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.Notes);

  }

  public static void SetNotes(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.Notes = Int32ValueConverter.CreateOpenXmlElement<DXEP.Notes>(value);
  }

  /// <summary>
  ///   Total Edit Time Metadata Element.
  /// </summary>
  public static Int32? GetTotalTime(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.TotalTime);

  }

  public static void SetTotalTime(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.TotalTime = Int32ValueConverter.CreateOpenXmlElement<DXEP.TotalTime>(value);
  }

  /// <summary>
  ///   Number of Hidden Slides.
  /// </summary>
  public static Int32? GetHiddenSlides(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.HiddenSlides);
  }

  public static void SetHiddenSlides(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.HiddenSlides = Int32ValueConverter.CreateOpenXmlElement<DXEP.HiddenSlides>(value);
  }

  /// <summary>
  ///   Total Number of Multimedia Clips.
  /// </summary>
  public static Int32? GetMultimediaClips(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.MultimediaClips);

  }

  public static void SetMultimediaClips(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.MultimediaClips = Int32ValueConverter.CreateOpenXmlElement<DXEP.MultimediaClips>(value);
  }

  /// <summary>
  ///   Thumbnail Display Mode.
  /// </summary>
  public static Boolean? GetScaleCrop(DXEP.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.ScaleCrop);
  }

  public static void SetScaleCrop(DXEP.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.ScaleCrop = BooleanValueConverter.CreateOpenXmlLeafTextElement<DXEP.ScaleCrop>(value);
  }

  /// <summary>
  ///   Heading Pairs.
  /// </summary>
  public static DMPr.HeadingPairs? GetHeadingPairs(DXEP.Properties openXmlElement)
  {
    return HeadingPairsConverter.CreateModelElement(openXmlElement?.HeadingPairs);
  }

  public static void SetHeadingPairs(DXEP.Properties openXmlElement, DMPr.HeadingPairs? value)
  {
    if (openXmlElement != null)
      openXmlElement.HeadingPairs = HeadingPairsConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  ///   Part Titles.
  /// </summary>
  public static StringList? GetTitlesOfParts(DXEP.Properties openXmlElement)
  {
    return TitlesOfPartsConverter.GetStrings(openXmlElement?.TitlesOfParts);
  }

  public static void SetTitlesOfParts(DXEP.Properties openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      TitlesOfPartsConverter.SetStrings(openXmlElement.TitlesOfParts, value);
  }

  /// <summary>
  ///   Links Up-to-Date.
  /// </summary>
  public static Boolean? GetLinksUpToDate(DXEP.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.LinksUpToDate);
  }

  public static void SetLinksUpToDate(DXEP.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.LinksUpToDate = BooleanValueConverter.CreateOpenXmlLeafTextElement<DXEP.LinksUpToDate>(value);
  }

  /// <summary>
  ///   Number of Characters (With Spaces).
  /// </summary>
  public static Int32? GetCharactersWithSpaces(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.CharactersWithSpaces);

  }

  public static void SetCharactersWithSpaces(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.CharactersWithSpaces = Int32ValueConverter.CreateOpenXmlElement<DXEP.CharactersWithSpaces>(value);
  }

  /// <summary>
  ///   Shared Document.
  /// </summary>
  public static Boolean? GetSharedDocument(DXEP.Properties openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.SharedDocument);
  }

  public static void SetSharedDocument(DXEP.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.SharedDocument = BooleanValueConverter.CreateOpenXmlLeafTextElement<DXEP.SharedDocument>(value);

  }

  /// <summary>
  ///   Relative Hyperlink Base.
  /// </summary>
  public static String? GetHyperlinkBase(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.HyperlinkBase?.Text;
  }

  public static void SetHyperlinkBase(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.HyperlinkBase { Text = value });
    }
  }

  /// <summary>
  ///   Hyperlink List.
  /// </summary>
  public static StringList? GetHyperlinkList(DXEP.Properties? openXmlElement)
  {
    return HyperlinkListConverter.GetStrings(openXmlElement?.HyperlinkList);
  }

  public static void SetHyperlinkList(DXEP.Properties openXmlElement, StringList? value)
  {
    if (openXmlElement != null)
      HyperlinkListConverter.SetStrings(openXmlElement.HyperlinkList, value);
  }

  /// <summary>
  ///   Hyperlinks Changed.
  /// </summary>
  public static Boolean? GetHyperlinksChanged(DXEP.Properties? openXmlElement)
  {
    return BooleanValueConverter.GetValue(openXmlElement?.HyperlinksChanged);
  }

  public static void SetHyperlinksChanged(DXEP.Properties openXmlElement, Boolean? value)
  {
    openXmlElement.HyperlinksChanged = BooleanValueConverter.CreateOpenXmlLeafTextElement<DXEP.HyperlinksChanged>(value);

  }

  /// <summary>
  ///   Digital Signature.
  /// </summary>
  public static byte[]? GetDigitalSignature(DXEP.Properties openXmlElement)
  {
    return DigitalSignatureConverter.CreateModelElement(openXmlElement?.DigitalSignature);
  }

  public static void SetDigitalSignature(DXEP.Properties openXmlElement, byte[]? value)
  {
    if (openXmlElement != null)
      openXmlElement.DigitalSignature = DigitalSignatureConverter.CreateOpenXmlElement(value);
  }

  /// <summary>
  ///   Application Name.
  /// </summary>
  public static String? GetApplication(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.Application?.Text;
  }

  public static void SetApplication(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.Application { Text = value });
    }
  }

  /// <summary>
  ///   Application Version.
  /// </summary>
  public static String? GetApplicationVersion(DXEP.Properties openXmlElement)
  {
    return openXmlElement?.ApplicationVersion?.Text;
  }

  public static void SetApplicationVersion(DXEP.Properties openXmlElement, String? value)
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
        openXmlElement?.AppendChild(new DXEP.ApplicationVersion { Text = value });
    }
  }

  /// <summary>
  ///   Document Security.
  /// </summary>
  public static Int32? GetDocumentSecurity(DXEP.Properties openXmlElement)
  {
    return Int32ValueConverter.GetValue(openXmlElement?.DocumentSecurity);
  }

  public static void SetDocumentSecurity(DXEP.Properties openXmlElement, Int32? value)
  {
    openXmlElement.DocumentSecurity = Int32ValueConverter.CreateOpenXmlElement<DXEP.DocumentSecurity>(value);
  }

  public static ContentProperties? GetContentProperties(DXEP.Properties? openXmlElement)
  {
    var model = new ContentProperties();
    if (openXmlElement != null)
    {
      model.Template = GetTemplate(openXmlElement);
      model.Manager = GetManager(openXmlElement);
      model.Company = GetCompany(openXmlElement);
      model.PresentationFormat = GetPresentationFormat(openXmlElement);
      model.ScaleCrop = GetScaleCrop(openXmlElement);
      model.HeadingPairs = GetHeadingPairs(openXmlElement);
      model.TitlesOfParts = GetTitlesOfParts(openXmlElement);
      model.LinksUpToDate = GetLinksUpToDate(openXmlElement);
      model.SharedDocument = GetSharedDocument(openXmlElement);
      model.HyperlinkBase = GetHyperlinkBase(openXmlElement);
      model.HyperlinkList = GetHyperlinkList(openXmlElement);
      model.HyperlinksChanged = GetHyperlinksChanged(openXmlElement);
      model.DigitalSignature = GetDigitalSignature(openXmlElement);
      model.Application = GetApplication(openXmlElement);
      model.ApplicationVersion = GetApplicationVersion(openXmlElement);
      model.DocumentSecurity = GetDocumentSecurity(openXmlElement);
    }
    return model;
  }

  public static StatisticProperties? GetStatisticProperties(DXEP.Properties? openXmlElement)
  {
    var model = new StatisticProperties();
    if (openXmlElement != null)
    {
      model.Pages = GetPages(openXmlElement);
      model.Words = GetWords(openXmlElement);
      model.Characters = GetCharacters(openXmlElement);
      model.CharactersWithSpaces = GetCharactersWithSpaces(openXmlElement);
      model.Lines = GetLines(openXmlElement);
      model.Paragraphs = GetParagraphs(openXmlElement);
      model.Slides = GetSlides(openXmlElement);
      model.Notes = GetNotes(openXmlElement);
      model.HiddenSlides = GetHiddenSlides(openXmlElement);
      model.MultimediaClips = GetMultimediaClips(openXmlElement);
      model.TotalTime = GetTotalTime(openXmlElement);
    }
    return model;
  }

  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(ContentProperties? model1, StatisticProperties? model2)
    where OpenXmlElementType : DXEP.Properties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    {
      if (model1 != null)
      {
        SetContentProperties(openXmlElement, model1);
      }
      if (model2 != null)
      {
        SetStatisticProperties(openXmlElement, model2);
      }
    }
    return openXmlElement;
  }

  public static void SetContentProperties(DXEP.Properties openXmlElement, ContentProperties model)
  {
    SetTemplate(openXmlElement, model.Template);
    SetManager(openXmlElement, model.Manager);
    SetCompany(openXmlElement, model.Company);
    SetPresentationFormat(openXmlElement, model.PresentationFormat);
    SetScaleCrop(openXmlElement, model.ScaleCrop);
    SetHeadingPairs(openXmlElement, model.HeadingPairs);
    SetTitlesOfParts(openXmlElement, model.TitlesOfParts);
    SetLinksUpToDate(openXmlElement, model.LinksUpToDate);
    SetSharedDocument(openXmlElement, model.SharedDocument);
    SetHyperlinkBase(openXmlElement, model.HyperlinkBase);
    SetHyperlinkList(openXmlElement, model.HyperlinkList);
    SetHyperlinksChanged(openXmlElement, model.HyperlinksChanged);
    SetDigitalSignature(openXmlElement, model.DigitalSignature);
    SetApplication(openXmlElement, model.Application);
    SetApplicationVersion(openXmlElement, model.ApplicationVersion);
    SetDocumentSecurity(openXmlElement, model.DocumentSecurity);
  }

  public static void SetStatisticProperties(DXEP.Properties openXmlElement, StatisticProperties model)
  {
    SetPages(openXmlElement, model.Pages);
    SetWords(openXmlElement, model.Words);
    SetCharacters(openXmlElement, model.Characters);
    SetCharactersWithSpaces(openXmlElement, model.CharactersWithSpaces);
    SetLines(openXmlElement, model.Lines);
    SetParagraphs(openXmlElement, model.Paragraphs);
    SetSlides(openXmlElement, model.Slides);
    SetNotes(openXmlElement, model.Notes);
    SetTotalTime(openXmlElement, model.TotalTime);
    SetHiddenSlides(openXmlElement, model.HiddenSlides);
    SetMultimediaClips(openXmlElement, model.MultimediaClips);
  }
}