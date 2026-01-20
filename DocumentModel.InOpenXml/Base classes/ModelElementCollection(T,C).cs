#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;

/// <summary>
/// Represents a collection of model elements that is associated with an OpenXml element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
/// <typeparam name="OpenXmlCollectionType">The type of the associated OpenXml element.</typeparam>
public abstract class ModelElementCollection<ItemType, OpenXmlCollectionType> : ElementCollection<ItemType> 
  where ItemType : ModelElement
  where OpenXmlCollectionType : DX.OpenXmlElement
{
  private OpenXmlCollectionType? _openXmlCollection;

  protected bool isLoading;

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
    base.CollectionChanged += (sender, e) =>
    {
      if (isLoading || _openXmlCollection == null)
        return;
      if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace || e.Action == NotifyCollectionChangedAction.Reset)
      {
        UpdateData(_openXmlCollection);
      }
    };
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlItemType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlCollection">The OpenXml element to wrap.</param>
  protected ModelElementCollection(OpenXmlCollectionType? openXmlCollection): this()
  {
    _openXmlCollection = openXmlCollection;
  }

  protected ModelElementCollection(IEnumerable<ItemType> items): this()
  {
    foreach (var item in items)
    {
      Add(item);
    }
  }

  /// <summary>
  /// Returns the wrapped OpenXml element instance.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public OpenXmlCollectionType? GetOpenXmlElement()
  {
    return _openXmlCollection;
  }

  /// <summary>
  /// Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public void SetOpenXmlElement(OpenXmlCollectionType? element)
  {
    _openXmlCollection = element;
  }

  /// <summary>
  /// Returns the OpenXml element instance for update operations.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return _openXmlCollection;
  }


  /// <summary>
  /// Override to load data using the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to load data from.</param>
  /// <remarks>Sets the isLoading flag to true while loading data.
  /// It avoids unnecessary updates by OnCollectionChanged event.</remarks>
  public override void LoadData(object openXmlElement)
  {
    isLoading = true;
    if (openXmlElement is OpenXmlCollectionType openXmlModeledElement)
    {
      LoadDataCollection(openXmlModeledElement);
    }
    isLoading = false;
  }


  /// <summary>
  /// Abstract method to load data from the modeled OpenXml collection to this instance.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract void LoadDataCollection(OpenXmlCollectionType openXmlModeledCollection);


  /// <summary>
  /// Override to store data to the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to store data to.</param>
  public override void UpdateData(object openXmlElement)
  {
    if (openXmlElement is OpenXmlCollectionType openXmlModeledElement)
    {
      UpdateDataCollection(openXmlModeledElement);
    }
  }

  /// <summary>
  /// Abstract method to store data from this instance to the modeled OpenXml collection.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract void UpdateDataCollection(OpenXmlCollectionType openXmlModeledCollection);
}
