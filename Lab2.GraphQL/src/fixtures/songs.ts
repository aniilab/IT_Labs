import { Song } from "../models/Song";
import { weeknd, lana, maneskin } from "./artists";

export const song1 = new Song("Lesser Man", "1", 2023, 185, weeknd);
export const song2 = new Song("Blinding Lights", "2", 2020, 190, weeknd);
export const song3 = new Song("Summertime Sadness", "3", 2017, 200, lana);
export const song4 = new Song("The Driver", "4", 2023, 180, maneskin);
