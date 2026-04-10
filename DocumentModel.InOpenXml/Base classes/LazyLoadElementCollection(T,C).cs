#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()
namespace DocumentModel;

/// <summary>
///   Represents a collection of model elements associated with an OpenXml element, providing synchronization between the document model and OpenXml elements.
///   Supports loading, updating, and detaching data from WordprocessingML or other OpenXml-based collections.
/// </summary>
/// <typeparam name="ItemType">Specifies the type of model elements contained in the collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">Specifies the type of the associated OpenXml element being wrapped and synchronized.</typeparam>
public class LazyLoadElementCollection<ItemType, OpenXmlCollectionType>:
  ModelElementCollection<ItemType, OpenXmlCollectionType>
  where ItemType : ModelElement
  where OpenXmlCollectionType : DX.OpenXmlCompositeElement
{

  /// <summary>
  ///   Default constructor.
  /// </summary>
  protected LazyLoadElementCollection()
  {
  }

  /// <summary>
  /// Initializing constructor that sets the parent element for this collection.
  /// </summary>
  /// <param name="parent">The model element that owns this collection. Cannot be null.</param>
  protected LazyLoadElementCollection(ModelElement parent) : base(parent)
  {
  }

  protected override void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    throw new NotImplementedException();
  }
  protected override void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection)
  {
    throw new NotImplementedException();
  }
}
