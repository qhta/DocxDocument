namespace DocumentModel.Wordprocessing;

/// <summary>
///   Interface Ifor Run property
/// </summary>
public interface IRunProperty: IModelElement, IUniqueModelElement<Type> 
{
  /// <summary>
  /// Parent as a <see cref="RunProperties"/> element.
  /// </summary>
  public new RunProperties? Parent
  {
    get => (this as IModelElement).Parent as RunProperties;
    set => (this as IModelElement).Parent = value;
  }

}
