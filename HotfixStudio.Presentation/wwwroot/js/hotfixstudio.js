// By disabling drag, Blazor no longer gets an error on drag drop for random text that causes this weird cursor bug.
// https://github.com/MicrosoftEdge/WebView2Feedback/issues/2805
document.addEventListener("dragstart", function (event) {
    event.preventDefault();
});