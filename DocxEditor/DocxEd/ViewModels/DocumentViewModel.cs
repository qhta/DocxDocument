using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DocumentModel.Wordprocessing;

using Qhta.MVVM;

namespace DocxEd.ViewModels;

public class DocumentViewModel : ViewModel<DocumentModel.Wordprocessing.Document>, IDisposable
{

  /// <summary>
  /// Initializing Constructor
  /// </summary>
  /// <param name="model">Model of the document to open</param>
  public DocumentViewModel(Document model) : base(model)
  {
  }

  /// <summary>
  /// Opens internal Wordprocessing document from a file.
  /// </summary>
  /// <param name="filename">Full Filename</param>
  /// <param name="readWrite">Open for modification</param>
  public void Open(string filename, bool readWrite = true)
  {
    Model.Open(filename, readWrite);
  }

  /// <summary>
  /// Closes opened WordprocessingDocument.
  /// </summary>
  public void Close()
  {
    Model.Close();
  }
  public string? Caption => Model.Filename;

  public string? Title => Model.Title;


  private bool disposedValue;

  protected virtual void Dispose(bool disposing)
  {
    if (!disposedValue)
    {
      if (disposing)
      {
        Model.Dispose();
      }

      // TODO: free unmanaged resources (unmanaged objects) and override finalizer
      // TODO: set large fields to null
      disposedValue = true;
    }
  }

  // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
  // ~DocumentViewModel()
  // {
  //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
  //     Dispose(disposing: false);
  // }

  public void Dispose()
  {
    // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
  }
}
