namespace DocumentModel.Drawings;
/// <summary>
/// Defines the color scheme for drawing elements.
/// </summary>
[OpenXmlType(typeof(DXD.ColorScheme))]
public partial class ColorScheme : ModelElement<DXD.ColorScheme>, IExtendableElement
{
  /// <summary>
  /// The scheme name, which identifies the color scheme.
  /// This name is used to reference the color scheme within the document and can be used by applications to apply specific color schemes to drawing elements.
  /// The name should be unique within the context of the document's theme and is typically defined in the theme part of the document.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }
  private string? _Name;
  /// <summary>
  /// <para>Dark 1.</para>
  /// <para>Represents the following element tag in the schema: a:dk1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Dark1Color { get; set; }
  /// <summary>
  /// <para>Light 1.</para>
  /// <para>Represents the following element tag in the schema: a:lt1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Light1Color { get; set; }
  /// <summary>
  /// <para>Dark 2.</para>
  /// <para>Represents the following element tag in the schema: a:dk2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Dark2Color { get; set; }
  /// <summary>
  /// <para>Light 2.</para>
  /// <para>Represents the following element tag in the schema: a:lt2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Light2Color { get; set; }
  /// <summary>
  /// <para>Accent 1.</para>
  /// <para>Represents the following element tag in the schema: a:accent1.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent1Color { get; set; }
  /// <summary>
  /// <para>Accent 2.</para>
  /// <para>Represents the following element tag in the schema: a:accent2.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent2Color { get; set; }
  /// <summary>
  /// <para>Accent 3.</para>
  /// <para>Represents the following element tag in the schema: a:accent3.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent3Color { get; set; }
  /// <summary>
  /// <para>Accent 4.</para>
  /// <para>Represents the following element tag in the schema: a:accent4.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent4Color { get; set; }
  /// <summary>
  /// <para>Accent 5.</para>
  /// <para>Represents the following element tag in the schema: a:accent5.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent5Color { get; set; }
  /// <summary>
  /// <para>Accent 6.</para>
  /// <para>Represents the following element tag in the schema: a:accent6.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Accent6Color { get; set; }
  /// <summary>
  /// <para>Hyperlink.</para>
  /// <para>Represents the following element tag in the schema: a:hlink.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? Hyperlink { get; set; }
  /// <summary>
  /// <para>Followed Hyperlink.</para>
  /// <para>Represents the following element tag in the schema: a:folHlink.</para>
  /// </summary>
  /// <remarks>
  /// xmlns:a = http://schemas.openxmlformats.org/drawingml/2006/main
  /// </remarks>
  public SchemeBaseColor? FollowedHyperlinkColor { get; set; }
  /// <summary>
  /// ExtensionList, which allows for additional properties or elements to be associated with the color scheme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.ColorScheme.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}