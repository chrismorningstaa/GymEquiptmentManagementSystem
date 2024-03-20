const changePath = (path) => {
    location = path;
}
const getQueryParameter = (name) => {

    let queryParam = new URLSearchParams(window.location.search);

    return queryParam.get(name)?.toString();

}