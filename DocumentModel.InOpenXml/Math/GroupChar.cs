namespace DocumentModel.Math;
/// <summary>
///   This element specifies the Group-Character object, consisting of a character drawn above or below text, 
///   often with the purpose of visually grouping items.
/// </summary>
public partial class GroupChar : ModelElement<DXM.GroupChar>, ICommonMathContent
{
    /// <summary>
    ///   Group-Character Properties.
    /// </summary>
    [OpenXmlProperty(nameof(DXM.GroupChar.GroupCharProperties))]
    /// <summary>
    ///   Group-Character Properties.
    /// </summary>
    [OpenXmlElement(typeof(DXM.GroupChar))]
    public GroupCharProperties? GroupCharProperties { get => _GroupCharProperties; set => UpdateField(ref _GroupCharProperties, value, nameof(GroupCharProperties)); }

    private GroupCharProperties? _GroupCharProperties;
    /// <summary>
    ///   Arugment of the group-character object.
    /// </summary>
    [OpenXmlElement(typeof(DXM.GroupChar))]
    public Argument? Argument { get => _Argument; set => UpdateField(ref _Argument, value, nameof(Argument)); }

    private Argument? _Argument;
}