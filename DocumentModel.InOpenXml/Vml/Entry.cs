namespace DocumentModel.Vml;

/// <summary>
///   Regroup Entry.
/// </summary>
[OpenXmlType(typeof(DXVO.Entry))]
[DataContract]
[XmlRoot("Entry", Namespace = "DocumentModel.Vml")]
public partial class Entry: ModelElement<DXVO.Entry>
{
  /// <summary>
  ///   New Group ID
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Entry.New))]
  public Int32? New
  {
    get => _New ??= GetProperty<Int32?>(GetUpdatableElement()?.New);
    set => UpdateField(ref _New, value, nameof(New));
  }

  private Int32? _New;

  /// <summary>
  ///   Old Group ID
  /// </summary>
  [OpenXmlProperty(nameof(DXVO.Entry.Old))]
  public Int32? Old
  {
    get => _Old ??= GetProperty<Int32?>(GetUpdatableElement()?.Old);
    set => UpdateField(ref _Old, value, nameof(Old));
  }

  private Int32? _Old;
}