using DocumentModel.BaseTypes;
namespace DocumentModel.Math;
/// <summary>
///   Interface for math elements that can be included in Office Math
/// </summary>
public interface IOfficeMathContent: IModelElement
{
  /// <summary>
  /// Parent as a <see cref="OfficeMath"/> element.
  /// </summary>
  public new DMM.OfficeMath? Parent
  {
    get => (this as IModelElement).Parent as OfficeMath;
    set => (this as IModelElement).Parent = value;
  }
}