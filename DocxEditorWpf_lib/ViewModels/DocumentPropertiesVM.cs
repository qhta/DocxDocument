using System.Collections.ObjectModel;

using DocumentModel;

using DocxEditor.ViewModels;

using Qhta.MVVM;

namespace DocxEditor.ViewsModels;

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
    foreach (var item in ModelCollection)
    {
      Add(new DocumentPropertyVM(item));
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