// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Get the picture url from the file upload
// Then put it in the PicUrl input to save the hotel
if (document.querySelector('#HotelsEdit'))
    {
    let picFileinput = document.querySelector('#PicUrl');
    picFileinput.addEventListener('change', getPicName);

    let picUrlinput = document.querySelector('#picUrlInput');


    // Get root path
    function getAppPath() {
        let pathArray = location.href
        let splitedPath = pathArray.split('/');
        let appPath = splitedPath[0] + '//' + splitedPath[2];
        return appPath;
    }

    // get pic url and associate it with root path
    function getPicName() {
        let picFakeUrl = picFileinput.value;
        let picName = picFakeUrl.split('\\');
        let picUrl = getAppPath() + '/images/' + picName[2];
        picUrlinput.value = picUrl;

        let picDisplay;
        if (document.querySelector('#picDisplay')) {
            picDisplay = document.querySelector('#picDisplay');
        } else {
            let picDisplayContainer = document.querySelector('#picDisplayContainer');
            picDisplay = document.createElement('img');
            picDisplay.classList.add('img-thumbnail');
            picDisplay.id = 'picDisplay';
            picDisplayContainer.appendChild(picDisplay);
        }
        picDisplay.src = picUrl;
    }
}


