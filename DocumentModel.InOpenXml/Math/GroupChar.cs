namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Group-Character object, consisting of a character drawn above or below text, 
///   often with the purpose of visually grouping items.
/// </summary>
[OpenXmlType(typeof(DXM.GroupChar))]
[XmlRoot("GroupChar", Namespace = "DocumentModel.Math")]
public partial class GroupChar : ModelElement<DXM.GroupChar>, ICommonMathContent
{
 /// <summary>
 ///   Group-Character Properties.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.GroupChar.GroupCharProperties))]
 public GroupCharProperties? GroupCharProperties { get => _GroupCharProperties; set => UpdateField(ref _GroupCharProperties, value, nameof(GroupCharProperties)); }
 private GroupCharProperties? _GroupCharProperties;

 /// <summary>
 ///   Specifies the argument of group char.
 /// </summary>
 [OpenXmlProperty(nameof(DXM.GroupChar.Base))]
 public Base? Base { get => _Base; set => UpdateField(ref _Base, value, nameof(Base)); }
 private Base? _Base;
}