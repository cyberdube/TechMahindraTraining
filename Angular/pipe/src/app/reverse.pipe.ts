import { Pipe, PipeTransform } from '@angular/core';

@Pipe({
  name: 'reverse'
})
export class ReversePipe implements PipeTransform {

  transform(value: string): string {
    return value
      .split('')
      .reverse()
      .map(char => {
        if (char >= 'a' && char <= 'z') {
          return '@';
        } else if (char >= 'A' && char <= 'Z') {
          return '#';
        } else {
          return char;
        }
      })
      .join('');
  }
}
