namespace DocumentModel;

/// <summary>
///   Interface for named model elements.
/// </summary>
public interface INamedModelElement: IModelElement
{
   public string Name { get; set; }
}