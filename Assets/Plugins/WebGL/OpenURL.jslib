mergeInto(LibraryManager.library, {
    OpenInNewTab: function (urlPtr) {
        var url = UTF8ToString(urlPtr);
        location.href = url; // Instead of window.open
    }
});
