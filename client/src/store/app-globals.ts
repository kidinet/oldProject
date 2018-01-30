import {Group} from '../entities/group';
import {User} from '../entities/user';
import {AboutTitle} from '../entities/about/aboutTitles';
import {ImageGallery} from '../entities/gallery/imageGallery'


// variables
export let baseAppUrl = 'http://localhost:4200/';
export let baseAPIUrl = 'http://localhost:7022/api/';

export let currentGroup = new Group();
export let currentUser = new User();

export let aboutTitles: AboutTitle[] = [];
export let imageGallery: ImageGallery[] = [];

export let likeItems = [];
export let likeItemsCount = {};


// setters
export function setGroup(groupParam) {
    this.currentGroup = groupParam;
}
export function setUser(user) {
    currentUser = user;
}
// ==================about=====================
export function addAboutTitles(aboutTitlesParam) {
    aboutTitles.push(aboutTitlesParam);
}
export function setAboutTitles(aboutTitlesArray) {
    aboutTitles = aboutTitlesArray;
}

// =================gallery=====================
export function toggleLikeItem(id) {
    let index = likeItems.indexOf(id);
    if (index == -1) {
        likeItemsCount[id]++;
        likeItems.push(id)
    }
    else {
        likeItemsCount[id]--;
        likeItems.splice(index, 1);
    }
}
export function addImagesForGallery(ImageGallryArray) {
    imageGallery.push.apply(imageGallery, ImageGallryArray);
}
export function setLikeItems(likeItemsArray) {
    likeItems = likeItemsArray;
}
export function setLikeItemsCount(likeItemsCountObject) {
    likeItemsCount = likeItemsCountObject;
}
export function deleteImageFromGallery(id) {
    let item = imageGallery.find((item) => {
        return item.id == id;
    })
    imageGallery.splice(imageGallery.indexOf(item), 1);
}


// getters
export function getCurrentUser() {
    return currentUser;
}

export function getCurrentGroup() {
    return currentGroup;
}
// ==================about===================
export function getAboutTitles() {
    return aboutTitles;
}

// ==========gallery=============
export function getImageGallery() {
    return imageGallery
}
export function getLikeItems() {
    return likeItems
}
export function getLikeItemsCount() {
    return likeItemsCount
}








