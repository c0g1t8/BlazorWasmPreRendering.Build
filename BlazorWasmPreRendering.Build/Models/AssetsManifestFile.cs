﻿namespace Toolbelt.Blazor.WebAssembly.PrerenderServer.Models
{
    public class AssetsManifestFile
    {
        public string? version { get; set; }

        public AssetsManifestFileEntry[]? assets { get; set; }
    }
}
