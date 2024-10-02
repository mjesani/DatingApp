import { Photo } from "./photo.model";

export interface Member {
    id: number;
    userName: string;
    photoUrl: string;
    age: number;
    gender: string;
    created: Date;
    lastActive: Date;
    knownAs: string;
    introduction: string;
    lookingFor: string;
    interests: string;
    city: string;
    country: string;
    photos: Photo[];
}

