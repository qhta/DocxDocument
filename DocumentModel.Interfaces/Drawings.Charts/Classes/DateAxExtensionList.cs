namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Defines the DateAxExtensionList Class.
/// </summary>
public interface DateAxExtensionList: IModelElement
{
  public Collection<DateAxExtension>? DateAxExtensions { get; set; }
}