namespace DocumentModel.Math;
/// <summary>
///   This element specifies the accent function, consisting of a base and a combining diacritical mark. 
///   If AccentProperties is omitted, the default accent is U+0302 (COMBINING CIRCUMFLEX ACCENT).
/// </summary>
[OpenXmlType(typeof(DXM.Accent))]
[XmlRoot("Accent", Namespace = "DocumentModel.Math")]
public partial class Accent : ModelElement<DXM.Accent>, ICommonMathContent
{
  /// <summary>
  ///   Specifies formatting properties of accent function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Accent.AccentProperties))]
  public AccentProperties? AccentProperties { get => _AccentProperties; set => UpdateField(ref _AccentProperties, value, nameof(AccentProperties)); }
  private AccentProperties? _AccentProperties;

  /// <summary>
  ///   Specifies the argument of accent function.
  /// </summary>
  [OpenXmlProperty(nameof(DXM.Accent.Base))]
  public Base? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }
  private Base? _Base;
}