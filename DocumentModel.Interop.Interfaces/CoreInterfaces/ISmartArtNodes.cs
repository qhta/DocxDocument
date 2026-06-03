using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `SmartArtNodes` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnodes?view=office-pia"/>
public interface ISmartArtNodes: IInteropCollection<ISmartArtNode>
{


  #region methods

/// <summary>
  /// Invokes `Add`.
  /// </summary>
  /// <returns>The result of the operation.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.smartartnodes.add?view=office-pia"/>
  public ISmartArtNode Add();

  #endregion methods
}

