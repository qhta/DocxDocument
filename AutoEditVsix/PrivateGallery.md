# AutoEdit private gallery

1. Build the extension (for example `Release`).
2. Generate gallery files:

```powershell
./Create-PrivateGallery.ps1 -GalleryBaseUrl "https://your-private-host/extensions/autoedit" -Configuration Release
```

This creates `PrivateGallery/Atom.xml` and `PrivateGallery/AutoEditVsix.vsix`.

3. Upload both files to your private host.
4. In Visual Studio, add the Atom feed URL (`.../Atom.xml`) as an additional extension source.

When you publish a new version:
- increase version in `source.extension.vsixmanifest`
- rebuild VSIX
- rerun the script
- upload updated `Atom.xml` and `AutoEditVsix.vsix`
