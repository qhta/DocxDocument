namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Algorithm.
/// </summary>
[OpenXmlType(typeof(DXDD.Algorithm))]
public partial class Algorithm : ModelElement<DXDD.Algorithm>
{
  /// <summary>
  ///   Algorithm Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Algorithm.Type))]
  public AlgorithmType? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }
  private AlgorithmType? _Type;
  /// <summary>
  ///   Revision Number
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Algorithm.Revision))]
  public UInt32? Revision { get => _Revision; set => UpdateField(ref _Revision, value, nameof(Revision)); }
  private UInt32? _Revision;
  /// <summary>
  /// Parameters.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.Parameter))]
  public Parameters? Parameters { get => _Parameters; set => UpdateField(ref _Parameters, value, nameof(Parameters)); }
  private Parameters? _Parameters;
  /// <summary>
  /// Extension List.
  /// </summary>
  [OpenXmlElement(typeof(DXDD.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }
  private ExtensionList? _ExtensionList;
}