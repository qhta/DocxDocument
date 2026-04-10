namespace DocumentModel.Wordprocessing;
/// <summary>
///   Represents the default paragraph and run properties for a WordprocessingML document.
///   This class provides properties for specifying the default character-level and paragraph-level formatting applied to all runs and paragraphs in the document unless overridden by more specific formatting.
/// </summary>
[OpenXmlType(typeof(DXW.DocDefaults))]
[XmlRoot("DocDefaults", Namespace = "DocumentModel.Wordprocessing")]
public sealed partial class DocDefaults : ModelElement<DXW.DocDefaults>
{
 /// <summary>
 /// Default constructor.
 /// </summary>
 public DocDefaults()
 {
 }

 /// <summary>
 /// Initializing constructor.
 /// </summary>
 /// <param name = "styles">The styles to attach to.</param>
 public DocDefaults(Styles styles)
 {
  if (styles.WordprocessingDocument != null)
   AttachAndLoad(styles.WordprocessingDocument);
 }

 /// <summary>
 ///   Default run properties, specifying the default character-level formatting for text runs.
 /// </summary>
 [OpenXmlUpdateData(nameof(UpdateDefaultRunPropertiesInOpenXml))]
 [OpenXmlLoadData(nameof(LoadDefaultRunProperties))]
 public BaseRunProperties? DefaultRunProperties { get => _defaultRunProperties; set => UpdateField(ref _defaultRunProperties, value, nameof(DefaultRunProperties)); }

 private BaseRunProperties? _defaultRunProperties;
 /// <summary>
 ///   Default paragraph properties, specifying the default paragraph-level formatting for paragraphs.
 /// </summary>
 [OpenXmlUpdateData(nameof(UpdateDefaultParagraphPropertiesInOpenXml))]
 [OpenXmlLoadData(nameof(LoadDefaultParagraphProperties))]
 public BaseParagraphProperties? DefaultParagraphProperties { get => _defaultParagraphProperties; set => UpdateField(ref _defaultParagraphProperties, value, nameof(DefaultParagraphProperties)); }

 private BaseParagraphProperties? _defaultParagraphProperties;
 /// <summary>
 /// Updates the default run properties in the specified Word document defaults to match the current default run
 /// properties.
 /// </summary>
 /// <remarks>This method is needed because the default run properties in the document defaults are defined
 /// as a DXW.RunPropertiesBaseStyle, which is a child element of the DXW.RunPropertiesDefault.</remarks>
 /// <param name = "wordDocDefaults">The document defaults object to update with the new run properties. This parameter cannot be null.</param>
 public void UpdateDefaultRunPropertiesInOpenXml(DXW.DocDefaults wordDocDefaults)
 {
  if (DefaultRunProperties != null)
  {
   var runPropertiesBaseStyle = (DXW.RunPropertiesBaseStyle)OpenXmlModelConverter.ConvertTo(DefaultRunProperties, typeof(DXW.RunPropertiesBaseStyle))!;
   wordDocDefaults.RunPropertiesDefault ??= new DXW.RunPropertiesDefault();
   wordDocDefaults.RunPropertiesDefault.RunPropertiesBaseStyle = runPropertiesBaseStyle;
  }
  else
  {
   if (wordDocDefaults.RunPropertiesDefault != null)
    wordDocDefaults.RunPropertiesDefault.RemoveAllChildren<DXW.RunPropertiesBaseStyle>();
   wordDocDefaults.RunPropertiesDefault = null;
  }
 }

 /// <summary>
 /// Loads the default run properties from the specified document defaults object.
 /// </summary>
 /// <remarks>This method is needed because the default run properties in the document defaults are defined
 /// as a DXW.RunPropertiesBaseStyle, which is a child element of the DXW.RunPropertiesDefault.</remarks>
 /// <param name = "wordDocDefaults">The document defaults object to load the new run properties from. This parameter cannot be null.</param>
 public void LoadDefaultRunProperties(DXW.DocDefaults wordDocDefaults)
 {
  var runPropertiesBaseStyle = wordDocDefaults.RunPropertiesDefault?.RunPropertiesBaseStyle;
  if (runPropertiesBaseStyle != null)
  {
   DefaultRunProperties = OpenXmlModelConverter.ConvertFrom(runPropertiesBaseStyle, typeof(BaseRunProperties)) as BaseRunProperties;
  }
 }

 /// <summary>
 /// Updates the default Paragraph properties in the specified Word document defaults to match the current default Paragraph
 /// properties.
 /// </summary>
 /// <remarks>This method is needed because the default Paragraph properties in the document defaults are defined
 /// as a DXW.ParagraphPropertiesBaseStyle, which is a child element of the DXW.ParagraphPropertiesDefault.</remarks>
 /// <param name = "wordDocDefaults">The document defaults object to update with the new Paragraph properties. This parameter cannot be null.</param>
 public void UpdateDefaultParagraphPropertiesInOpenXml(DXW.DocDefaults wordDocDefaults)
 {
  if (DefaultParagraphProperties != null)
  {
   var ParagraphPropertiesBaseStyle = (DXW.ParagraphPropertiesBaseStyle)OpenXmlModelConverter.ConvertTo(DefaultParagraphProperties, typeof(DXW.ParagraphPropertiesBaseStyle))!;
   wordDocDefaults.ParagraphPropertiesDefault ??= new DXW.ParagraphPropertiesDefault();
   wordDocDefaults.ParagraphPropertiesDefault.ParagraphPropertiesBaseStyle = ParagraphPropertiesBaseStyle;
  }
  else
  {
   if (wordDocDefaults.ParagraphPropertiesDefault != null)
    wordDocDefaults.ParagraphPropertiesDefault.RemoveAllChildren<DXW.ParagraphPropertiesBaseStyle>();
   wordDocDefaults.ParagraphPropertiesDefault = null;
  }
 }

 /// <summary>
 /// Loads the default Paragraph properties from the specified document defaults object.
 /// </summary>
 /// <remarks>This method is needed because the default Paragraph properties in the document defaults are defined
 /// as a DXW.ParagraphPropertiesBaseStyle, which is a child element of the DXW.ParagraphPropertiesDefault.</remarks>
 /// <param name = "wordDocDefaults">The document defaults object to load the new Paragraph properties from. This parameter cannot be null.</param>
 public void LoadDefaultParagraphProperties(DXW.DocDefaults wordDocDefaults)
 {
  var ParagraphPropertiesBaseStyle = wordDocDefaults.ParagraphPropertiesDefault?.ParagraphPropertiesBaseStyle;
  if (ParagraphPropertiesBaseStyle != null)
  {
   DefaultParagraphProperties = OpenXmlModelConverter.ConvertFrom(ParagraphPropertiesBaseStyle, typeof(BaseParagraphProperties)) as BaseParagraphProperties;
  }
 }
}