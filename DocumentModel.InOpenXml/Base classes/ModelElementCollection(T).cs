using System.Text.Json;

#pragma warning disable CS0659 // Type overrides Object.Equals(object o) but does not override Object.GetHashCode()

namespace DocumentModel;

/// <summary>
/// Represents a collection of model elements that is associated with an OpenXml element.
/// </summary>
/// <typeparam name="ItemType">The type of elements contained in the collection.</typeparam>
/// <typeparam name="OpenXmlType">The type of the associated OpenXml element.</typeparam>
public abstract class ModelElementCollection<ItemType, OpenXmlType> : ElementCollection<ItemType> 
  where ItemType : ModelElement
  where OpenXmlType : DX.OpenXmlElement
{
  private OpenXmlType? _openXmlElement;

  protected bool isLoading;

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlType}"/> class.
  /// </summary>
  protected ModelElementCollection()
  {
    base.CollectionChanged += (sender, e) =>
    {
      if (isLoading || _openXmlElement == null)
        return;
      if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove || e.Action == NotifyCollectionChangedAction.Replace || e.Action == NotifyCollectionChangedAction.Reset)
      {
        UpdateData(_openXmlElement);
      }
    };
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="ModelElement{OpenXmlType}"/> class with the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to wrap.</param>
  protected ModelElementCollection(OpenXmlType? openXmlElement): this()
  {
    _openXmlElement = openXmlElement;
  }

  /// <summary>
  /// Returns the wrapped OpenXml element instance.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  public OpenXmlType? GetOpenXmlElement()
  {
    return _openXmlElement;
  }

  /// <summary>
  /// Assigns the wrapped OpenXml element instance.
  /// </summary>
  /// <param name="element">The OpenXml element to assign.</param>
  public void SetOpenXmlElement(OpenXmlType? element)
  {
    _openXmlElement = element;
  }

  /// <summary>
  /// Returns the OpenXml element instance for update operations.
  /// </summary>
  /// <returns>The OpenXml element instance, or null if not set.</returns>
  protected override object? GetUpdatableOpenXmlElement()
  {
    return _openXmlElement;
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
    if (openXmlElement is OpenXmlType openXmlModeledElement)
    {
      LoadDataCollection(openXmlModeledElement);
    }
    isLoading = false;
  }


  /// <summary>
  /// Abstract method to load data from the modeled OpenXml collection to this instance.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to load data from.</param>
  protected abstract void LoadDataCollection(OpenXmlType openXmlModeledCollection);


  /// <summary>
  /// Override to store data to the specified OpenXml element.
  /// </summary>
  /// <param name="openXmlElement">The OpenXml element to store data to.</param>
  public override void UpdateData(object openXmlElement)
  {
    if (openXmlElement is OpenXmlType openXmlModeledElement)
    {
      UpdateDataCollection(openXmlModeledElement);
    }
  }

  /// <summary>
  /// Abstract method to store data from this instance to the modeled OpenXml collection.
  /// </summary>
  /// <param name="openXmlModeledCollection">The OpenXml collection to store data to.</param>
  protected abstract void UpdateDataCollection(OpenXmlType openXmlModeledCollection);
}
