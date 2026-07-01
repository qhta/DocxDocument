namespace DocumentModel.Math;
/// <summary>
///   This element specifies the border-box object, consisting of a border drawn around an instance of mathematical text 
///   (such as a formula or equation). If borderBoxPr is omitted then the default behavior of borderBox is a rectangular border 
/// </summary>
[OpenXmlType(typeof(DXM.BorderBox))]
[DataContract]
[XmlRoot("BorderBox", Namespace = "DocumentModel.Math")]
public partial class BorderBox : ModelElement<DXM.BorderBox>, ICommonMathContent
{
 /// <summary>
 ///   Specifies properties of border-box object.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBox.BorderBoxProperties))]
 public BorderBoxProperties? BorderBoxProperties { get => _BorderBoxProperties; set => UpdateField(ref _BorderBoxProperties, value, nameof(BorderBoxProperties)); }
 private BorderBoxProperties? _BorderBoxProperties;

 /// <summary>
 ///   Specifies the argument of border-box function.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.BorderBox.Base))]
 public Base? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }
 private Base? _Base;

}