namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Represents a reference to numeric values for a chart, including formula, numbering cache, and extension list.
/// </summary>
[OpenXmlType(typeof(DXDC.NumberReference))]
public partial class NumberReference: ModelElement<DXDC.NumberReference>
{
  /// <summary>
  ///   Formula used to reference the numeric values.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumberReference.Formula))]
  public string? Formula { get => _Formula; set => UpdateField(ref _Formula, value, nameof(Formula)); }
  private string? _Formula;
  /// <summary>
  ///   Numbering cache containing the referenced numeric values.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.NumberReference.NumberingCache))]
  public NumberingCache? NumberingCache
  {
    get => _NumberingCache;
    set => UpdateField(ref _NumberingCache, value, nameof(NumberingCache));
  }
  private NumberingCache? _NumberingCache;
  /// <summary>
  ///   Extension list for additional number reference properties.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.NumRefExtensionList))]
  public NumRefExtension? NumRefExtension
  {
    get => _NumRefExtension;
    set => UpdateField(ref _NumRefExtension, value, nameof(NumRefExtension));
  }
  private NumRefExtension? _NumRefExtension;
}