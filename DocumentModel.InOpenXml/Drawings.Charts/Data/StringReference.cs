namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Represents a reference to string data for a chart.
///   This class defines the formula used to retrieve the string data, the cache of string values, and any extension lists.
/// </summary>
[OpenXmlType(typeof(DXDC.StringReference))]
[DataContract]
[XmlRoot("StringReference", Namespace = "DocumentModel.Drawings.Charts")]
public partial class StringReference: ModelElement<DXDC.StringReference>
{
  /// <summary>
  ///   Formula used to reference the string data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.StringReference.Formula))]
  public string? Formula
  {
    get => _Formula ??= GetProperty<string?>(GetUpdatableElement()?.Formula);
    set => UpdateField(ref _Formula, value, nameof(Formula));
  }

  private string? _Formula;

  /// <summary>
  ///   Cache of string values referenced by the formula.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.StringReference.StringCache))]
  public StringCache? StringCache
  {
    get => _StringCache ??= GetProperty<StringCache?>(GetUpdatableElement()?.StringCache);
    set => UpdateField(ref _StringCache, value, nameof(StringCache));
  }

  private StringCache? _StringCache;

  /// <summary>
  ///   Extension element for additional string reference properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.StrRefExtensionList))]
  public StrRefExtension? StrRefExtension
  {
    get => _StrRefExtension ??= GetElement<StrRefExtension, DXDC.StrRefExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _StrRefExtension, value, nameof(StrRefExtension));
  }

  private StrRefExtension? _StrRefExtension;
}