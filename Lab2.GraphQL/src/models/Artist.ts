import { Entity, Column, BaseEntity, OneToMany } from "typeorm";
import { ObjectType, Field, ID } from "type-graphql";
import { Song } from "./Song";
// import { v4 as uuidv4 } from 'uuid'; 


@ObjectType()
@Entity()
export class Artist extends BaseEntity {
  @Field(() => ID)
  id: string;

  @Field()
  @Column()
  fullName: string;

  @Field()
  @Column()
  pseudoName: string;

  @Field()
  @Column()
  country: string;

  @OneToMany(() => Song, (song) => song.author)
  songs: Song[];

  constructor(fullName: string, pseudoName: string, id: string, country: string) {
    super();
    // this.id = uuidv4(); 
    this.id = id
    this.fullName = fullName;
    this.pseudoName = pseudoName;
    this.country = country;
    this.songs = [];
  }
}
