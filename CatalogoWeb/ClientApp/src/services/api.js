import axios from 'axios';

const api = axios.create({
    baseURL:'https://localhost:44312/api/'
});

export default api;