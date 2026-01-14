namespace DocumentModel.Wordprocessing;

/// <summary>
///   Common base class for <see cref="InsertedRun"/>, <see cref="DeletedRun"/>, <see cref="MoveFromRun"/>, and <see cref="MoveToRun"/>.
///   Provides run-level revision tracking, including author, date, annotation identifier, and run content collection.
///   Implements <see cref="IElementCollection{IParagraphContent}"/> and <see cref="ICommonContent"/>.
/// </summary>
public class RunTrackChangeType : IdentifiedChange, IElementCollection<IParagraphContent>, ICommonContent
{
  private readonly ParagraphContentCollection _elementCollectionImplementation = new();

  /// <summary>
  /// Returns an enumerator that iterates through the run content collection.
  /// </summary>
  public IEnumerator<IParagraphContent> GetEnumerator()
  {
    return _elementCollectionImplementation.GetEnumerator();
  }

  /// <summary>
  /// Returns an enumerator that iterates through the run content collection (non-generic).
  /// </summary>
  IEnumerator IEnumerable.GetEnumerator()
  {
    return ((IEnumerable)_elementCollectionImplementation).GetEnumerator();
  }

  /// <summary>
  /// Adds a run content item to the collection.
  /// </summary>
  /// <param name="item">The run content item to add.</param>
  public void Add(IParagraphContent item)
  {
    _elementCollectionImplementation.Add(item);
  }

  /// <summary>
  /// Removes all run content items from the collection.
  /// </summary>
  public void Clear()
  {
    _elementCollectionImplementation.Clear();
  }

  /// <summary>
  /// Determines whether the collection contains a specific run content item.
  /// </summary>
  /// <param name="item">The run content item to locate.</param>
  /// <returns>True if found; otherwise, false.</returns>
  public bool Contains(IParagraphContent item)
  {
    return _elementCollectionImplementation.Contains(item);
  }

  /// <summary>
  /// Copies the elements of the collection to an array, starting at a particular array index.
  /// </summary>
  /// <param name="array">The destination array.</param>
  /// <param name="arrayIndex">The zero-based index at which copying begins.</param>
  public void CopyTo(IParagraphContent[] array, int arrayIndex)
  {
    _elementCollectionImplementation.CopyTo(array, arrayIndex);
  }

  /// <summary>
  /// Removes the first occurrence of a specific run content item from the collection.
  /// </summary>
  /// <param name="item">The run content item to remove.</param>
  /// <returns>True if removed; otherwise, false.</returns>
  public bool Remove(IParagraphContent item)
  {
    return _elementCollectionImplementation.Remove(item);
  }

  /// <summary>
  /// Gets the number of run content items in the collection.
  /// </summary>
  public int Count => _elementCollectionImplementation.Count;

  /// <summary>
  /// Indicates whether the collection is read-only.
  /// </summary>
  public bool IsReadOnly => false;

  /// <summary>
  /// Determines the index of a specific run content item in the collection.
  /// </summary>
  /// <param name="item">The run content item to locate.</param>
  /// <returns>The index if found; otherwise, -1.</returns>
  public int IndexOf(IParagraphContent item)
  {
    return _elementCollectionImplementation.IndexOf(item);
  }

  /// <summary>
  /// Inserts a run content item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index at which to insert.</param>
  /// <param name="item">The run content item to insert.</param>
  public void Insert(int index, IParagraphContent item)
  {
    _elementCollectionImplementation.Insert(index, item);
  }

  /// <summary>
  /// Removes the run content item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index of the item to remove.</param>
  public void RemoveAt(int index)
  {
    _elementCollectionImplementation.RemoveAt(index);
  }

  /// <summary>
  /// Gets or sets the run content item at the specified index.
  /// </summary>
  /// <param name="index">The zero-based index.</param>
  /// <returns>The run content item at the specified index.</returns>
  public IParagraphContent this[int index]
  {
    get => _elementCollectionImplementation[index];
    set => _elementCollectionImplementation[index] = value;
  }
}