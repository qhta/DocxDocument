using System.Runtime.Serialization;
namespace DocumentModel.Drawings;
/// <summary>
///  Abstract class representing any fill properties. Concrete fill classes are:
///  <list type="table">
///    <term>NoFill</term><description>The shape is not filled.</description>
///    <term>SolidFill</term><description>The shape is filled entirely with the specified color.</description>
///    <term>GradientFill</term><description>The shape is filled with a smooth gradual transition from one color to the next.</description>
///    <term>BlipFill</term><description>The shape is filled with a picture.</description>
///    <term>ParrentFill</term><description>The shape is filled with a repeated pattern.</description>
///    <term>GroupFill</term><description>The shape is a part of a group and should inherit the fill properties of the group.</description>
///  </list>
/// </summary>
[KnownType(typeof(NoFill))]
[KnownType(typeof(SolidFill))]
[KnownType(typeof(GradientFill))]
[KnownType(typeof(BlipFill))]
[KnownType(typeof(PatternFill))]
[KnownType(typeof(GroupFill))]
public abstract class Fill: ITypedModelElement, IDrawingProperty
{
}