function addHeaderIDs() {
  document.querySelectorAll("h1, h2, h3, h4, h5").forEach((heading) => {
    const text = heading.textContent?.trim();
    heading.id = text;
  });
}
async function loadMarkdown() {
  const response = await fetch(
    "https://raw.githubusercontent.com/cheaderthecoder/5-Letter-words/main/README.md"
  );
  const markdownContent = await response.text();
  return markdownContent;
}
(async () => {
  const markdownContent = await loadMarkdown();

  document.getElementById("markdown").innerHTML = marked.parse(markdownContent);
  hljs.highlightAll();
  addHeaderIDs();
})();
