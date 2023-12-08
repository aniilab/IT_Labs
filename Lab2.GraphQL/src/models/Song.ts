import { Entity, Column, BaseEntity } from "typeorm";
import { ObjectType, Field, ID } from "type-graphql";
import { Artist } from "./Artist";
// import { v4 as uuidv4 } from 'uuid'; 

@ObjectType()
@Entity()
export class Song extends BaseEntity {
  @Field(() => ID)
  id: string;

  @Field()
  @Column()
  title: string;

  @Field()
  @Column()
  year: number;

  @Field()
  @Column()
  duration: number;

  @Field(() => Artist)
  author: Artist;

  constructor(title: string, id: string, year: number, duration: number, author: Artist) {
    super();
    // this.id = uuidv4(); 
    this.id = id
    this.title = title;
    this.duration = duration;
    this.year = year;
    this.author = author;
  }
}
