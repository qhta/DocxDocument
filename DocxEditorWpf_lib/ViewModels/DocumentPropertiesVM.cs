namespace DocxEditor.ViewModels;

/// <summary>
/// ViewModel for DocumentModel.DocumentProperties.
/// </summary>
public sealed class DocumentPropertiesVM : ObservableCollection<DocumentPropertyVM>
{
  /// <summary>
  /// Initializing constructor.
  /// </summary>
  /// <param name="modelCollection"></param>
  public DocumentPropertiesVM(DocumentProperties modelCollection)
  {
    ModelCollection = modelCollection;
    ModelCollection.CoreProperties ??= new DocumentModel.CoreProperties(modelCollection.OwnerDocument!);
    foreach (var item in ModelCollection.CoreProperties.GetKnownProperties())
    {
      var property = ModelCollection.GetProperty(item.Key);
      if (property == null)
      {
        property = new DocumentProperty(item.Key, item.Value.PropertyType);
      }
      var propertyVM = new DocumentPropertyVM(property);
      Add(propertyVM);
    }
    CollectionChanged += DocumentPropertiesVM_CollectionChanged;
  }

  private void DocumentPropertiesVM_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
  {
    if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Add)
    {
      foreach (DocumentPropertyVM item in e.NewItems!)
      {
        ModelCollection.Add(item.Model);
      }
    }
    else if (e.Action == System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
    {
      foreach (DocumentPropertyVM item in e.OldItems!)
      {
        ModelCollection.Remove(item.Model);
      }
    }
  }

  /// <summary>
  /// Model collection of document properties.
  /// </summary>
  private readonly DocumentModel.DocumentProperties ModelCollection;
}