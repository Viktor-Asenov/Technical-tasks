window.onload = function (event) {
  event.target.addEventListener('click', getElementDescendants);

  function getElementDescendants(ev) {
    const arrayOfElements = [];

    let targetElement = ev.target;
    const descendants = Array.prototype.slice.call(
      targetElement.querySelectorAll('*')
    );

    arrayOfElements.push(targetElement);

    descendants.forEach(function (descendant) {
      arrayOfElements.push(descendant);
    });

    console.log(arrayOfElements);
  }
};
