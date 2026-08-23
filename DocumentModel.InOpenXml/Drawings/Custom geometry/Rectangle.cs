namespace DocumentModel.Drawings;

/// <summary>
///   This element specifies the rectangular bounding box for text within a custom geometry.
///   The default for this rectangle is the bounding box for the shape.
///   This can be modified using this elements four attributes to inset or extend the text bounding box.
/// </summary>
/// <remarks>
/// Text specified to reside within this shape text rectangle can flow outside this bounding box.
/// Depending on the autofit options within the txBody element the text might not entirely reside within this shape text rectangle. 
/// </remarks>
[OpenXmlType(typeof(DXD.Rectangle))]
[DataContract]
[XmlRoot("Rectangle", Namespace = "DocumentModel.Drawings")]
public partial class Rectangle: ModelElement<DXD.Rectangle>
{
  /// <summary>
  ///   Left position of the rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Rectangle.Left))]
  public string? Left
  {
    get => _Left ??= GetProperty<string?>(GetUpdatableElement()?.Left);
    set => UpdateField(ref _Left, value, nameof(Left));
  }

  private string? _Left;

  /// <summary>
  ///   Top position of the rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Rectangle.Top))]
  public string? Top
  {
    get => _Top ??= GetProperty<string?>(GetUpdatableElement()?.Top);
    set => UpdateField(ref _Top, value, nameof(Top));
  }

  private string? _Top;

  /// <summary>
  ///   Right position of the rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Rectangle.Right))]
  public string? Right
  {
    get => _Right ??= GetProperty<string?>(GetUpdatableElement()?.Right);
    set => UpdateField(ref _Right, value, nameof(Right));
  }

  private string? _Right;

  /// <summary>
  ///   Bottom position of the rectangle.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.Rectangle.Bottom))]
  public string? Bottom
  {
    get => _Bottom ??= GetProperty<string?>(GetUpdatableElement()?.Bottom);
    set => UpdateField(ref _Bottom, value, nameof(Bottom));
  }

  private string? _Bottom;
}