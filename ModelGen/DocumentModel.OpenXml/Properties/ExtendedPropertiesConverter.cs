namespace DocumentModel.OpenXml.Properties;

/// <summary>
/// Application Specific File Properties.
/// </summary>
public static class ExtendedPropertiesConverter
{
  /// <summary>
  /// Name of Document Template.
  /// </summary>
  private static String? GetTemplate(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Template>()?.Text;
  }
  
  private static bool CmpTemplate(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Template>()?.Text == value;
  }
  
  private static void SetTemplate(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Template>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Template { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Name of Manager.
  /// </summary>
  private static String? GetManager(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Manager>()?.Text;
  }
  
  private static bool CmpManager(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Manager>()?.Text == value;
  }
  
  private static void SetManager(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Manager>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Manager { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Name of Company.
  /// </summary>
  private static String? GetCompany(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Company>()?.Text;
  }
  
  private static bool CmpCompany(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Company>()?.Text == value;
  }
  
  private static void SetCompany(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Company>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Company { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Total Number of Pages.
  /// </summary>
  private static String? GetPages(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Pages>()?.Text;
  }
  
  private static bool CmpPages(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Pages>()?.Text == value;
  }
  
  private static void SetPages(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Pages>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Pages { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Word Count.
  /// </summary>
  private static String? GetWords(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Words>()?.Text;
  }
  
  private static bool CmpWords(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Words>()?.Text == value;
  }
  
  private static void SetWords(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Words>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Words { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Total Number of Characters.
  /// </summary>
  private static String? GetCharacters(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Characters>()?.Text;
  }
  
  private static bool CmpCharacters(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Characters>()?.Text == value;
  }
  
  private static void SetCharacters(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Characters>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Characters { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Intended Format of Presentation.
  /// </summary>
  private static String? GetPresentationFormat(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.PresentationFormat>()?.Text;
  }
  
  private static bool CmpPresentationFormat(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.PresentationFormat>()?.Text == value;
  }
  
  private static void SetPresentationFormat(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.PresentationFormat>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.PresentationFormat { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number of Lines.
  /// </summary>
  private static String? GetLines(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Lines>()?.Text;
  }
  
  private static bool CmpLines(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Lines>()?.Text == value;
  }
  
  private static void SetLines(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Lines>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Lines { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Total Number of Paragraphs.
  /// </summary>
  private static String? GetParagraphs(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Paragraphs>()?.Text;
  }
  
  private static bool CmpParagraphs(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Paragraphs>()?.Text == value;
  }
  
  private static void SetParagraphs(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Paragraphs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Paragraphs { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Slides Metadata Element.
  /// </summary>
  private static String? GetSlides(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Slides>()?.Text;
  }
  
  private static bool CmpSlides(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Slides>()?.Text == value;
  }
  
  private static void SetSlides(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Slides>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Slides { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number of Slides Containing Notes.
  /// </summary>
  private static String? GetNotes(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Notes>()?.Text;
  }
  
  private static bool CmpNotes(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Notes>()?.Text == value;
  }
  
  private static void SetNotes(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Notes>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Notes { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Total Edit Time Metadata Element.
  /// </summary>
  private static String? GetTotalTime(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.TotalTime>()?.Text;
  }
  
  private static bool CmpTotalTime(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.TotalTime>()?.Text == value;
  }
  
  private static void SetTotalTime(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.TotalTime>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.TotalTime { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number of Hidden Slides.
  /// </summary>
  private static String? GetHiddenSlides(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HiddenSlides>()?.Text;
  }
  
  private static bool CmpHiddenSlides(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HiddenSlides>()?.Text == value;
  }
  
  private static void SetHiddenSlides(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.HiddenSlides>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.HiddenSlides { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Total Number of Multimedia Clips.
  /// </summary>
  private static String? GetMultimediaClips(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.MultimediaClips>()?.Text;
  }
  
  private static bool CmpMultimediaClips(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.MultimediaClips>()?.Text == value;
  }
  
  private static void SetMultimediaClips(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.MultimediaClips>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.MultimediaClips { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Thumbnail Display Mode.
  /// </summary>
  private static String? GetScaleCrop(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.ScaleCrop>()?.Text;
  }
  
  private static bool CmpScaleCrop(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.ScaleCrop>()?.Text == value;
  }
  
  private static void SetScaleCrop(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.ScaleCrop>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.ScaleCrop { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Heading Pairs.
  /// </summary>
  private static DMProps.HeadingPairs? GetHeadingPairs(DXExtProps.Properties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXExtProps.HeadingPairs>();
    if (element != null)
      return DMXProps.HeadingPairsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHeadingPairs(DXExtProps.Properties openXmlElement, DMProps.HeadingPairs? value, DiffList? diffs, string? objName)
  {
    return DMXProps.HeadingPairsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXExtProps.HeadingPairs>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHeadingPairs(DXExtProps.Properties openXmlElement, DMProps.HeadingPairs? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.HeadingPairs>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXProps.HeadingPairsConverter.CreateOpenXmlElement<DXExtProps.HeadingPairs>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Part Titles.
  /// </summary>
  private static DMProps.TitlesOfParts? GetTitlesOfParts(DXExtProps.Properties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXExtProps.TitlesOfParts>();
    if (element != null)
      return DMXProps.TitlesOfPartsConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpTitlesOfParts(DXExtProps.Properties openXmlElement, DMProps.TitlesOfParts? value, DiffList? diffs, string? objName)
  {
    return DMXProps.TitlesOfPartsConverter.CompareModelElement(openXmlElement.GetFirstChild<DXExtProps.TitlesOfParts>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetTitlesOfParts(DXExtProps.Properties openXmlElement, DMProps.TitlesOfParts? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.TitlesOfParts>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXProps.TitlesOfPartsConverter.CreateOpenXmlElement<DXExtProps.TitlesOfParts>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Links Up-to-Date.
  /// </summary>
  private static String? GetLinksUpToDate(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.LinksUpToDate>()?.Text;
  }
  
  private static bool CmpLinksUpToDate(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.LinksUpToDate>()?.Text == value;
  }
  
  private static void SetLinksUpToDate(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.LinksUpToDate>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.LinksUpToDate { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Number of Characters (With Spaces).
  /// </summary>
  private static String? GetCharactersWithSpaces(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.CharactersWithSpaces>()?.Text;
  }
  
  private static bool CmpCharactersWithSpaces(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.CharactersWithSpaces>()?.Text == value;
  }
  
  private static void SetCharactersWithSpaces(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.CharactersWithSpaces>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.CharactersWithSpaces { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Shared Document.
  /// </summary>
  private static String? GetSharedDocument(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.SharedDocument>()?.Text;
  }
  
  private static bool CmpSharedDocument(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.SharedDocument>()?.Text == value;
  }
  
  private static void SetSharedDocument(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.SharedDocument>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.SharedDocument { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Relative Hyperlink Base.
  /// </summary>
  private static String? GetHyperlinkBase(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HyperlinkBase>()?.Text;
  }
  
  private static bool CmpHyperlinkBase(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HyperlinkBase>()?.Text == value;
  }
  
  private static void SetHyperlinkBase(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.HyperlinkBase>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.HyperlinkBase { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlink List.
  /// </summary>
  private static DMProps.HyperlinkList? GetHyperlinkList(DXExtProps.Properties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXExtProps.HyperlinkList>();
    if (element != null)
      return DMXProps.HyperlinkListConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpHyperlinkList(DXExtProps.Properties openXmlElement, DMProps.HyperlinkList? value, DiffList? diffs, string? objName)
  {
    return DMXProps.HyperlinkListConverter.CompareModelElement(openXmlElement.GetFirstChild<DXExtProps.HyperlinkList>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetHyperlinkList(DXExtProps.Properties openXmlElement, DMProps.HyperlinkList? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.HyperlinkList>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXProps.HyperlinkListConverter.CreateOpenXmlElement<DXExtProps.HyperlinkList>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Hyperlinks Changed.
  /// </summary>
  private static String? GetHyperlinksChanged(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HyperlinksChanged>()?.Text;
  }
  
  private static bool CmpHyperlinksChanged(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.HyperlinksChanged>()?.Text == value;
  }
  
  private static void SetHyperlinksChanged(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.HyperlinksChanged>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.HyperlinksChanged { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Digital Signature.
  /// </summary>
  private static DMProps.DigitalSignature? GetDigitalSignature(DXExtProps.Properties openXmlElement)
  {
    var element = openXmlElement?.GetFirstChild<DXExtProps.DigitalSignature>();
    if (element != null)
      return DMXProps.DigitalSignatureConverter.CreateModelElement(element);
    return null;
  }
  
  private static bool CmpDigitalSignature(DXExtProps.Properties openXmlElement, DMProps.DigitalSignature? value, DiffList? diffs, string? objName)
  {
    return DMXProps.DigitalSignatureConverter.CompareModelElement(openXmlElement.GetFirstChild<DXExtProps.DigitalSignature>(), value, diffs, objName?.Concat2(".",openXmlElement?.GetType().Name));
  }
  
  private static void SetDigitalSignature(DXExtProps.Properties openXmlElement, DMProps.DigitalSignature? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.DigitalSignature>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = DMXProps.DigitalSignatureConverter.CreateOpenXmlElement<DXExtProps.DigitalSignature>(value);
      if (itemElement != null)
        openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Application Name.
  /// </summary>
  private static String? GetApplication(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Application>()?.Text;
  }
  
  private static bool CmpApplication(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.Application>()?.Text == value;
  }
  
  private static void SetApplication(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.Application>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.Application { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Application Version.
  /// </summary>
  private static String? GetApplicationVersion(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.ApplicationVersion>()?.Text;
  }
  
  private static bool CmpApplicationVersion(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.ApplicationVersion>()?.Text == value;
  }
  
  private static void SetApplicationVersion(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.ApplicationVersion>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.ApplicationVersion { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  /// <summary>
  /// Document Security.
  /// </summary>
  private static String? GetDocumentSecurity(DXExtProps.Properties openXmlElement)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.DocumentSecurity>()?.Text;
  }
  
  private static bool CmpDocumentSecurity(DXExtProps.Properties openXmlElement, String? value, DiffList? diffs, string? objName)
  {
      return openXmlElement?.GetFirstChild<DXExtProps.DocumentSecurity>()?.Text == value;
  }
  
  private static void SetDocumentSecurity(DXExtProps.Properties openXmlElement, String? value)
  {
    var itemElement = openXmlElement.GetFirstChild<DXExtProps.DocumentSecurity>();
    if (itemElement != null)
      itemElement.Remove();
    if (value != null)
    {
      itemElement = new DXExtProps.DocumentSecurity { Text = value };
      openXmlElement.AddChild(itemElement);
    }
  }
  
  public static DocumentModel.Properties.ExtendedProperties? CreateModelElement(DXExtProps.Properties? openXmlElement)
  {
    if (openXmlElement != null)
    {
      var value = new DocumentModel.Properties.ExtendedProperties();
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
      return value;
    }
    return null;
  }
  
  public static bool CompareModelElement(DXExtProps.Properties? openXmlElement, DMProps.ExtendedProperties? value, DiffList? diffs, string? objName)
  {
    if (openXmlElement != null && value != null)
    {
      var ok = true;
      if (!CmpTemplate(openXmlElement, value.Template, diffs, objName))
        ok = false;
      if (!CmpManager(openXmlElement, value.Manager, diffs, objName))
        ok = false;
      if (!CmpCompany(openXmlElement, value.Company, diffs, objName))
        ok = false;
      if (!CmpPages(openXmlElement, value.Pages, diffs, objName))
        ok = false;
      if (!CmpWords(openXmlElement, value.Words, diffs, objName))
        ok = false;
      if (!CmpCharacters(openXmlElement, value.Characters, diffs, objName))
        ok = false;
      if (!CmpPresentationFormat(openXmlElement, value.PresentationFormat, diffs, objName))
        ok = false;
      if (!CmpLines(openXmlElement, value.Lines, diffs, objName))
        ok = false;
      if (!CmpParagraphs(openXmlElement, value.Paragraphs, diffs, objName))
        ok = false;
      if (!CmpSlides(openXmlElement, value.Slides, diffs, objName))
        ok = false;
      if (!CmpNotes(openXmlElement, value.Notes, diffs, objName))
        ok = false;
      if (!CmpTotalTime(openXmlElement, value.TotalTime, diffs, objName))
        ok = false;
      if (!CmpHiddenSlides(openXmlElement, value.HiddenSlides, diffs, objName))
        ok = false;
      if (!CmpMultimediaClips(openXmlElement, value.MultimediaClips, diffs, objName))
        ok = false;
      if (!CmpScaleCrop(openXmlElement, value.ScaleCrop, diffs, objName))
        ok = false;
      if (!CmpHeadingPairs(openXmlElement, value.HeadingPairs, diffs, objName))
        ok = false;
      if (!CmpTitlesOfParts(openXmlElement, value.TitlesOfParts, diffs, objName))
        ok = false;
      if (!CmpLinksUpToDate(openXmlElement, value.LinksUpToDate, diffs, objName))
        ok = false;
      if (!CmpCharactersWithSpaces(openXmlElement, value.CharactersWithSpaces, diffs, objName))
        ok = false;
      if (!CmpSharedDocument(openXmlElement, value.SharedDocument, diffs, objName))
        ok = false;
      if (!CmpHyperlinkBase(openXmlElement, value.HyperlinkBase, diffs, objName))
        ok = false;
      if (!CmpHyperlinkList(openXmlElement, value.HyperlinkList, diffs, objName))
        ok = false;
      if (!CmpHyperlinksChanged(openXmlElement, value.HyperlinksChanged, diffs, objName))
        ok = false;
      if (!CmpDigitalSignature(openXmlElement, value.DigitalSignature, diffs, objName))
        ok = false;
      if (!CmpApplication(openXmlElement, value.Application, diffs, objName))
        ok = false;
      if (!CmpApplicationVersion(openXmlElement, value.ApplicationVersion, diffs, objName))
        ok = false;
      if (!CmpDocumentSecurity(openXmlElement, value.DocumentSecurity, diffs, objName))
        ok = false;
      return ok;
    }
    if (openXmlElement == null && value == null) return true;
    diffs?.Add(objName, openXmlElement?.GetType().Name, openXmlElement, value);
    return false;
  }
  
  public static OpenXmlElementType CreateOpenXmlElement<OpenXmlElementType>(DMProps.ExtendedProperties value)
    where OpenXmlElementType: DXExtProps.Properties, new()
  {
    var openXmlElement = new OpenXmlElementType();
    UpdateOpenXmlElement(openXmlElement, value);
    return openXmlElement;
  }
  
  public static void UpdateOpenXmlElement(DXExtProps.Properties openXmlElement, DMProps.ExtendedProperties value)
  {
    SetTemplate(openXmlElement, value?.Template);
    SetManager(openXmlElement, value?.Manager);
    SetCompany(openXmlElement, value?.Company);
    SetPages(openXmlElement, value?.Pages);
    SetWords(openXmlElement, value?.Words);
    SetCharacters(openXmlElement, value?.Characters);
    SetPresentationFormat(openXmlElement, value?.PresentationFormat);
    SetLines(openXmlElement, value?.Lines);
    SetParagraphs(openXmlElement, value?.Paragraphs);
    SetSlides(openXmlElement, value?.Slides);
    SetNotes(openXmlElement, value?.Notes);
    SetTotalTime(openXmlElement, value?.TotalTime);
    SetHiddenSlides(openXmlElement, value?.HiddenSlides);
    SetMultimediaClips(openXmlElement, value?.MultimediaClips);
    SetScaleCrop(openXmlElement, value?.ScaleCrop);
    SetHeadingPairs(openXmlElement, value?.HeadingPairs);
    SetTitlesOfParts(openXmlElement, value?.TitlesOfParts);
    SetLinksUpToDate(openXmlElement, value?.LinksUpToDate);
    SetCharactersWithSpaces(openXmlElement, value?.CharactersWithSpaces);
    SetSharedDocument(openXmlElement, value?.SharedDocument);
    SetHyperlinkBase(openXmlElement, value?.HyperlinkBase);
    SetHyperlinkList(openXmlElement, value?.HyperlinkList);
    SetHyperlinksChanged(openXmlElement, value?.HyperlinksChanged);
    SetDigitalSignature(openXmlElement, value?.DigitalSignature);
    SetApplication(openXmlElement, value?.Application);
    SetApplicationVersion(openXmlElement, value?.ApplicationVersion);
    SetDocumentSecurity(openXmlElement, value?.DocumentSecurity);
  }
}
