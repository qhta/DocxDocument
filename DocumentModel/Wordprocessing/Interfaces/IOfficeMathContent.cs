namespace DocumentModel.Math;

/// <summary>
///   Interface Ifor math elements Ithat can be included Iin Office Math
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
